using DALLogistica.Entities;
using System;
using System.Collections.Generic;
using DALLogistica.Repository;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using DALSenhas.Repository;
using Logistica.Sistema_Financeiro_Estoque;

namespace LogisticaEntregas
{
    public partial class FrmPropostas : Form
    {
        static int pesquisar = 1;
        internal Proposta _proposta;
        internal ItensProposta _itensProposta;
        internal CadastrarEmpresa _fabrica;
        internal CadastrarMadeira _madeira;
        public FrmPropostas()
        {
            InitializeComponent();
        }
        private void FrmPropostas_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                tabPage3.BackColor = Color.FromArgb(0, 64, 0);
                HabilitarCampos(false);
                #region _proposta
                if (_proposta == null)
                    _proposta = new Proposta();
                if (_proposta.PropostaId > 0)
                {
                    HabilitarCampos(true);
                    #region Codigos
                    _proposta = new DLProposta().ConsultarPorId(_proposta.PropostaId);
                    txtPropostId.Text = _proposta.PropostaId.ToString();
                    dtpDataPrevista.Value = _proposta.DataPrevista;
                    dtpDataPedido.Value = _proposta.DataPedido;
                    txtFabrica.Text = _proposta.Fabrica;
                    txtFaturado.Text = _proposta.Faturado;
                    txtFormaPag.Text = _proposta.FormaPag;
                    txtEngResp.Text = _proposta.EngResp;
                    txtTelefone.Text = _proposta.Telefone;
                    txtPdRb.Text = _proposta.PdRb;
                    txtPdVenda.Text = _proposta.PdVenda;
                    txtProposta.Text = _proposta.Propostaa;
                    txtEmpresa.Text = _proposta.Construtora;
                    txtObra.Text = _proposta.Obra;
                    dtpDataEntrega.Value = _proposta.DataEntrega;
                    txtRecebido.Text = _proposta.RecebidoPor;
                    txtNotaFiscal.Text = _proposta.NotaFiscal;
                    txtCarreto.Text = _proposta.Carreto;
                    rtbmaterial.Text = _proposta.Material;
                    #endregion
                    switch (_proposta.StatusobraId)//escolha
                    {
                        case 1:
                            {
                                rbImediato.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                rbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                rbCancelado.Checked = true;
                            }
                            break;
                    }
                    CarregarGridItensProposta();
                    CarregarGridHistorico();
                    BloquearBotao(false);
                }
                else
                {
                    rbImediato.Checked = true;
                }
                #endregion
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void CarregarGridHistorico()
        {
            try
            {
                var listarHistorico = new DLHistorico().Listar().Where(p => p.PropostaId == Convert.ToInt32(txtPropostId.Text)).ToList();
                DgvHistorico.DataSource = null; 
                DgvHistorico.DataSource = listarHistorico.OrderByDescending(p => p.DataComentario).ToList();
                DgvHistorico.Refresh(); 
                MontarGridHistorico();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridHistorico()
        {
            try
            {
                DgvHistorico.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvHistorico);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "DataComentario", "Comentario", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data do Comentario", "Comentario", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 80 }, DgvHistorico.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BloquearBotao(bool desabilitar)
        {
            btnCriarProposta.Enabled = desabilitar;
            btnSalvarComentario.Enabled = desabilitar;
        }
        private void CarregarGridItensProposta()
        {
            try
            {
                var listaItensProposta = new DLItensProposta().Listar().Where(p => p.PropostaId == Convert.ToInt32(txtPropostId.Text)).ToList();
                Dgvmaterial.DataSource = null; 
                Dgvmaterial.DataSource = listaItensProposta;
                Dgvmaterial.Refresh(); 
                MontarGridItensProposta(Dgvmaterial); 
                txtTotalPedido.Text = listaItensProposta.Sum(p => p.Total).ToString("C");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridItensProposta(DataGridView dgvmaterial)
        {
            try
            {
                Dgvmaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(Dgvmaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "UndMedida", "Quantidade", "Preco", "M2NotaFiscal", "ObsMaterial", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Und Medida", "Quantidade", "Valor", "Qtd Caixa", "Obs Material", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 51, 5, 8, 7, 5, 10, 10 }, Dgvmaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void HabilitarCampos(bool Habilitar)
        {
            txtCodigoFabrica.Enabled = Habilitar;
            txtCodigoFaturado.Enabled = Habilitar;
            txtCodigoCliente.Enabled = Habilitar;
            txtCodigoMaterial.Enabled = Habilitar;
            dtpDataPrevista.Enabled = Habilitar;
            rtbmaterial.Enabled = Habilitar;
            btnSalvarComentario.Enabled = Habilitar;
            btnImpressao.Enabled = Habilitar;
            dtpDataPedido.Enabled = Habilitar;
            txtFormaPag.Enabled = Habilitar;
            btnDeletar.Enabled = Habilitar;
            txtEngResp.Enabled = Habilitar;
            txtTelefone.Enabled = Habilitar;
            txtPdRb.Enabled = Habilitar;
            txtPdVenda.Enabled = Habilitar;
            txtProposta.Enabled = Habilitar;
            txtObra.Enabled = Habilitar;
            rtbComentario.Enabled = Habilitar;
            dtpDataEntrega.Enabled = Habilitar;
            txtRecebido.Enabled = Habilitar;
            txtNotaFiscal.Enabled = Habilitar;
            txtCarreto.Enabled = Habilitar;
            btnApagar.Enabled = Habilitar;
            btnCliente.Enabled = Habilitar;
            btnCodigo.Enabled = Habilitar;
            btnFabrica.Enabled = Habilitar;
            btnFaturado.Enabled = Habilitar;
            btnGravar.Enabled = Habilitar;
            txtQuantidade.Enabled = Habilitar;
            txtPreco.Enabled = Habilitar;
            txtUndMedida.Enabled = Habilitar;
            rtbObsMaterial.Enabled = Habilitar;
            btnSalvar.Enabled = Habilitar;
            btnLimparCampos.Enabled = Habilitar;
            btnApagar.Enabled = Habilitar;
        }
        private void BtnCriarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new Proposta();
                proposta.StatusobraId = 2;//Pendente
                var id = new DLProposta().Inserir(proposta);//inserir
                txtPropostId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void BtnFabrica_Click(object sender, EventArgs e)
        {
            try
            {
                pesquisar = 1;
                PegarDados_FormCadastroEmpresa();                        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }           
        }
        public void PegarDados_FormCadastroEmpresa()
        {
            try
            {
                FrmCadastroEmpresa cadasEmpr = new FrmCadastroEmpresa();
                cadasEmpr.ShowDialog();
                var id = cadasEmpr.empresaid;
                var empresa = cadasEmpr.empresa;
                switch (pesquisar)
                {
                    case 1:
                        {
                            txtCodigoFabrica.Text = id.ToString();
                            txtFabrica.Text = empresa;
                        }
                        break;
                    case 2:
                        {
                            txtCodigoFaturado.Text = id.ToString();
                            txtFaturado.Text = empresa;
                        }
                        break;
                    case 3:
                        {
                            txtCodigoCliente.Text = id.ToString();
                            txtEmpresa.Text = empresa;
                        }
                        break;
                }
                cadasEmpr.Close();
                cadasEmpr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnFaturado_Click(object sender, EventArgs e)
        {
            pesquisar = 2;
            PegarDados_FormCadastroEmpresa();

        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            pesquisar = 3;
            PegarDados_FormCadastroEmpresa();
        }
        private void LimparDadosProposta()
        {
            dtpDataPrevista.Value = DateTime.Now;
            dtpDataPedido.Value = DateTime.Now;
            txtFabrica.Text = Convert.ToString(null);
            txtFaturado.Text = Convert.ToString(null);
            txtFormaPag.Text = Convert.ToString(null); ;
            txtEngResp.Text = Convert.ToString(null);
            txtTelefone.Text = Convert.ToString(null);
            txtPdRb.Text = Convert.ToString(null);
            txtPdVenda.Text = Convert.ToString(null);
            txtProposta.Text = Convert.ToString(null);
            txtEmpresa.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
            rtbComentario.Text = Convert.ToString("Nota Fiscal do material sera enviada por e-mail, qualquer duvida entrar em contato com a Rb Pisos.");
            dtpDataEntrega.Value = DateTime.Now;
            txtRecebido.Clear();
            txtNotaFiscal.Clear();
            txtCarreto.Clear();
            rtbmaterial.Text = Convert.ToString("Nota Fiscal do material sera enviada por e-mail, qualquer duvida entrar em contato com a Rb Pisos.");
        }
        private bool ValidarCampos()
        {
            if (txtProposta.Text == "")
            {
                throw new Exception(" Informe a Proposta ");
            }
            else if (rtbmaterial.Text == "")
            {
                throw new Exception("Informe o Material");
            }
            return true;
        }
        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroItens cadastroItens = new FrmCadastroItens();
                cadastroItens.ShowDialog();
                var id = cadastroItens.madeiraid;
                var material = cadastroItens.material;
                var comprimento = cadastroItens.comprimento;
                var qtdcaixa = cadastroItens.qtdcaixa;
                txtCodigoMaterial.Text = id.ToString();
                txtMaterial.Text = material;
                txtm2Caixas.Text = qtdcaixa;
                cadastroItens.Close();
                cadastroItens.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCamposItens()
        {
            try
            {
                txtItensPropostaId.Text = Convert.ToString(null);
                txtCodigoMaterial.Text = Convert.ToString(null);
                txtMaterial.Text = Convert.ToString("Nome do Item ");
                txtQuantidade.Text = Convert.ToString(0);
                txtPreco.Text = Convert.ToString(0);
                txtm2Caixas.Text = Convert.ToString(0);
                txtUndMedida.Text = Convert.ToString("m²");
                txtQuantidadeCaixas.Text = Convert.ToString(0);
                rtbObsMaterial.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private ItensProposta LerCampos()
        {
            try
            {
                var iten = new ItensProposta();
                int id = 0;
                int.TryParse(txtItensPropostaId.Text, out id);
                if (id == 0)
                {
                    iten.CodigoMaterial = Convert.ToInt32(txtCodigoMaterial.Text);
                    iten.Material = txtMaterial.Text;
                    iten.ObsMaterial = rtbObsMaterial.Text; 
                    iten.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                    iten.Preco = Convert.ToDecimal(txtPreco.Text); 
                    iten.M2NotaFiscal = txtQuantidadeCaixas.Text;
                    iten.UndMedida = txtUndMedida.Text; 
                    iten.Total = Convert.ToDecimal(txtTotal.Text);
                    iten.PropostaId = Convert.ToInt32(txtPropostId.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MetragemCaixas()
        {
            try
            {
                decimal qtd = 0, caixa = 0, total = 0;
                if (decimal.TryParse(txtm2Caixas.Text, out qtd))
                {
                    if (decimal.TryParse(txtQuantidade.Text, out caixa))
                    {
                        total = caixa / qtd;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                    txtQuantidadeCaixas.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ValorMaterial()
        {
            try
            {
                decimal qtd = 0, valor = 0, total = 0;
                if (decimal.TryParse(txtQuantidade.Text, out qtd))
                {
                    if (decimal.TryParse(txtPreco.Text, out valor))
                    {
                        total = qtd * valor;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                }
                txtTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Dgvmaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var itensProposta = Dgvmaterial.Rows[e.RowIndex].DataBoundItem as ItensProposta;
                if (itensProposta != null)
                {
                    txtItensPropostaId.Text = itensProposta.ItenId.ToString();
                    txtMaterial.Text = itensProposta.Material;
                    txtUndMedida.Text = itensProposta.UndMedida;
                    txtm2Caixas.Text = Convert.ToString(itensProposta.M2caixa);
                    txtQuantidade.Text = Convert.ToString(itensProposta.Quantidade);
                    txtPreco.Text = Convert.ToString(itensProposta.Preco);
                    txtQuantidadeCaixas.Text = itensProposta.M2NotaFiscal;
                    rtbObsMaterial.Text = itensProposta.ObsMaterial;
                    txtTotal.Text = Convert.ToString(itensProposta.Total);
                    txtCodigoMaterial.Text = Convert.ToString(itensProposta.CodigoMaterial);
                }               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtPropostId.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLProposta().ConsultarPorId(id);
                        pAtua.DataPrevista = dtpDataPrevista.Value; 
                        pAtua.DataPedido = dtpDataPedido.Value;
                        pAtua.Fabrica = txtFabrica.Text;
                        pAtua.Faturado = txtFaturado.Text;
                        pAtua.FormaPag = txtFormaPag.Text; 
                        pAtua.EngResp = txtEngResp.Text;
                        pAtua.Telefone = txtTelefone.Text;
                        pAtua.PdRb = txtPdRb.Text;
                        pAtua.PdVenda = txtPdVenda.Text;
                        pAtua.Propostaa = txtProposta.Text;
                        pAtua.Construtora = txtEmpresa.Text; 
                        pAtua.Obra = txtObra.Text;
                        pAtua.DataEntrega = dtpDataEntrega.Value;
                        pAtua.RecebidoPor = txtRecebido.Text;
                        pAtua.NotaFiscal = txtNotaFiscal.Text;
                        pAtua.Carreto = txtCarreto.Text;
                        pAtua.Material = rtbmaterial.Text;
                        if (rbImediato.Checked == true)
                            pAtua.StatusobraId = 1;
                        else if (rbPendente.Checked == true)
                            pAtua.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            pAtua.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            pAtua.StatusobraId = 4;
                        new DLProposta().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparDadosProposta();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private Historico LerComentario()
        {
            try
            {
                var historico = new Historico();
                int id = 0;
                int.TryParse(txtHistorico.Text, out id);
                if (id == 0)
                {
                    historico.Comentario = rtbComentario.Text;
                    historico.DataComentario = dtpHistorico.Value;
                    historico.PropostaId = Convert.ToInt32(txtPropostId.Text);
                }
                return historico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnImpressao_Click(object sender, EventArgs e)
        {
            try
            { 
                #region Tabela Itens Proposta
                ReportDataSource iP = new ReportDataSource();
                List<ItensProposta> lst = new List<ItensProposta>();
                lst.Clear();
                for (int i = 0; i < Dgvmaterial.Rows.Count - 0; i++)
                {
                    lst.Add(new ItensProposta   
                    {                         
                        ItenId =   int.Parse(Dgvmaterial.Rows[i].Cells[0].Value.ToString()),
                        Material = Dgvmaterial.Rows[i].Cells[1].Value.ToString(),
                        UndMedida = Dgvmaterial.Rows[i].Cells[2].Value.ToString(),
                        Quantidade = Convert.ToDecimal(Dgvmaterial.Rows[i].Cells[4].Value.ToString()),
                        M2NotaFiscal = Dgvmaterial.Rows[i].Cells[6].Value.ToString(),
                    });
                }
                iP.Name = "DataSet";
                iP.Value = lst;
                #endregion

                #region Tabela Historico de Comentario
                ReportDataSource hS = new ReportDataSource();
                List<Historico> histo = new List<Historico>();
                histo.Clear();
                for (int i = 0; i < DgvHistorico.Rows.Count - 0; i++)
                {
                    histo.Add(new Historico
                    {
                        HistoricoId = int.Parse(DgvHistorico.Rows[i].Cells[0].Value.ToString()),
                        Comentario = DgvHistorico.Rows[i].Cells[2].Value.ToString(),
                        DataComentario = Convert.ToDateTime(DgvHistorico.Rows[i].Cells[1].Value.ToString()),
                    });
                }
                hS.Name = "Historico";
                hS.Value = histo;
                #endregion
                FrmImpressao frmImpressao = new FrmImpressao(dtpDataEntrega.Value, txtProposta.Text, txtEmpresa.Text, txtObra.Text, iP, txtNotaFiscal.Text, rtbComentario.Text, hS);
                frmImpressao.reportViewer1.LocalReport.DataSources.Clear();
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(iP);
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(hS);
                frmImpressao.reportViewer1.LocalReport.ReportEmbeddedResource = "Logistica.RelatorioPDF.rdlc";
                frmImpressao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLSenha().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senhas == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int ide = 0;
                        int.TryParse(txtPropostId.Text, out ide);
                        if (ide > 0)
                        {
                            new DLProposta().Excluir(new Proposta { PropostaId = ide });
                            MessageBox.Show("Proposta excluída com sucesso!");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnGravar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var itenProposta = LerCampos();
                int ItensPropostaId = 0;
                if (txtItensPropostaId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(txtItensPropostaId.Text);
                }
                int propostaid = 0;
                if (txtPropostId.Text != "")
                {
                    propostaid = Convert.ToInt32(txtPropostId.Text);
                }
                var listaProposta = new DLItensProposta().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.PropostaId == propostaid //por proppostaid
                                && ip.ItenId == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.ItenId > 0)
                {
                    prop.M2caixa = Convert.ToDecimal(txtm2Caixas.Text);
                    prop.M2NotaFiscal = txtQuantidadeCaixas.Text;
                    prop.Material = txtMaterial.Text;
                    prop.Preco = Convert.ToDecimal(txtPreco.Text);
                    prop.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                    prop.ObsMaterial = rtbObsMaterial.Text;
                    prop.UndMedida = txtUndMedida.Text;
                    prop.Total = Convert.ToDecimal(txtTotal.Text);
                    new DLItensProposta().Atualizar(prop);
                }
                else
                {
                    new DLItensProposta().Inserir(itenProposta);
                }
                LimparCamposItens();
                CarregarGridItensProposta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnApagar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtItensPropostaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLItensProposta().ConsultarPorId(id);
                    if (prop.ItenId > 0)
                    {
                        new DLItensProposta().Excluir(prop);
                        CarregarGridItensProposta();
                        LimparCamposItens();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o item da proposta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
        }
        private void BtnSalvarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                var comentario = LerComentario();
                int historicoComentario = 0;
                if (txtHistorico.Text != "")
                {
                    historicoComentario = Convert.ToInt32(txtHistorico.Text);
                }
                int propostaid = 0;
                if (txtPropostId.Text != "")
                {
                    propostaid = Convert.ToInt32(txtPropostId.Text);
                }
                var listaHistorico = new DLHistorico().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaHistorico.Where(ip => ip.PropostaId == propostaid //por proppostaid
                                && ip.HistoricoId == historicoComentario //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.HistoricoId > 0)
                {
                    prop.Comentario = rtbComentario.Text;
                    prop.DataComentario = dtpHistorico.Value;
                    new DLHistorico().Atualizar(prop);
                }
                else
                {
                    new DLHistorico().Inserir(comentario);
                }
                CarregarGridHistorico();
                rtbComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LiberarSalvamentoComentario(bool verdadeiro)
        {
            btnSalvarComentario.Enabled = verdadeiro;
        }
        private void RtbComentario_Click(object sender, EventArgs e)
        {
            LiberarSalvamentoComentario(true);
        }
        private void BtnDeletarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtHistorico.Text, out id);
                if (id > 0)
                {
                    var prop = new DLHistorico().ConsultarPorId(id);
                    if (prop.HistoricoId > 0)
                    {
                        new DLHistorico().Excluir(prop);
                        txtHistorico.Clear();
                        CarregarGridHistorico();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o item da proposta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtHistorico.Clear();
            rtbComentario.Clear();
            CarregarGridHistorico();
        }
        private void DgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var historico = DgvHistorico.Rows[e.RowIndex].DataBoundItem as Historico;
                if( historico != null)
                {
                    txtHistorico.Text = historico.HistoricoId.ToString();
                    rtbComentario.Text = historico.Comentario;
                    dtpHistorico.Value = historico.DataComentario;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            FrmEstoqueFinanceiro financeiro = new FrmEstoqueFinanceiro();
            financeiro.ShowDialog();
        }
        private void TxtCodigoFabrica_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int ide = 1;
                int.TryParse(txtCodigoFabrica.Text, out ide);
                if (ide > 1)
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(txtCodigoFabrica.Text));
                    txtCodigoFabrica.Text = _fabrica.EmpresaId.ToString();
                    txtFabrica.Text = _fabrica.Empresa;
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Cliente não cadastrado, use a lupa para pesquisar o cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoFaturado_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int ide = 0;
                int.TryParse(txtCodigoFaturado.Text, out ide);
                if (ide > 1)
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(txtCodigoFaturado.Text));
                    txtCodigoFaturado.Text = _fabrica.EmpresaId.ToString();
                    txtFaturado.Text = _fabrica.Empresa;
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Cliente não cadastrado, use a lupa para pesquisar o cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoCliente_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int ide = 0;
                int.TryParse(txtCodigoCliente.Text, out ide);
                if (ide > 1)
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(txtCodigoCliente.Text));
                    txtCodigoCliente.Text = _fabrica.EmpresaId.ToString();
                    txtEmpresa.Text = _fabrica.Empresa;
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Cliente não cadastrado, use a lupa para pesquisar o cliente.");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoMaterial_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int ide = 0;
                int.TryParse(txtCodigoMaterial.Text, out ide);
                if (ide > 1)
                {
                    _madeira = new DLCadastrarMadeira().ConsultarPorId(Convert.ToInt32(txtCodigoMaterial.Text));
                    txtCodigoMaterial.Text = _madeira.MadeiraId.ToString();
                    txtMaterial.Text = _madeira.PisoMadeira;
                    txtm2Caixas.Text = Convert.ToString(_madeira.M2Caixa);
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Material não cadastrado, use a lupa para pesquisar o material.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtPreco_TextChanged_1(object sender, EventArgs e)
        {
            ValorMaterial();
        }
        private void TxtQtdCaixas_TextChanged(object sender, EventArgs e)
        {
            ValorMaterial();
            MetragemCaixas();
        }
        private void TxtQtd_TextChanged(object sender, EventArgs e)
        {
            MetragemCaixas();
        }
    }
}

