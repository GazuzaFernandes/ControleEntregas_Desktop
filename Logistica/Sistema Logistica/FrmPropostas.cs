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
                if (_proposta == null)
                    _proposta = new Proposta();
                if (_proposta.propostaid > 0)
                {
                    HabilitarCampos(true);
                    #region Codigos
                    _proposta = new DLProposta().ConsultarPorId(_proposta.propostaid);
                    TxtPropostId.Text = _proposta.propostaid.ToString();
                    dtpDataPrevista.Value = _proposta.dataprevista;
                    DtpDataPedido.Value = _proposta.datapedido;
                    TxtFabrica.Text = _proposta.fabrica;
                    TxtFaturado.Text = _proposta.faturado;
                    TxtFormaPag.Text = _proposta.formapag;
                    TxtEngResp.Text = _proposta.engresp;
                    TxtTelefone.Text = _proposta.telefone;
                    TxtPdRb.Text = _proposta.pdrb;
                    TxtPdVenda.Text = _proposta.pdvenda;
                    TxtProposta.Text = _proposta.propostaa;
                    TxtEmpresa.Text = _proposta.construtora;
                    TxtObra.Text = _proposta.obra;
                    DtpDataEntrega.Value = _proposta.dataentrega;
                    TxtRecebido.Text = _proposta.recebidopor;
                    TxtNotaFiscal.Text = _proposta.notafiscal;
                    TxtCarreto.Text = _proposta.carreto;
                    Rtbmaterial.Text = _proposta.material;
                    #endregion
                    switch (_proposta.statusobraid)//escolha
                    {
                        case 1:
                            {
                                RbImediato.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                RbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                RbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                RbCancelado.Checked = true;
                            }
                            break;
                    }
                    Carregargrid();
                    carregarhistorico();
                    BloquearBotao(false);
                }
                else
                {
                    RbImediato.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void carregarhistorico()
        {
            try
            {
                var listarHistorico = new DLHistorico().Listar().Where(p => p.propostaid == Convert.ToInt32(TxtPropostId.Text)).ToList();
                DgvHistorico.DataSource = null; DgvHistorico.DataSource = listarHistorico.OrderByDescending(p => p.datacomentario).ToList();
                DgvHistorico.Refresh(); MontarHistorico();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarHistorico()
        {
            try
            {
                DgvHistorico.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvHistorico);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "datacomentario", "comentario", });
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
            BtnCriarProposta.Enabled = desabilitar;
            BtnSalvarComentario.Enabled = desabilitar;
        }
        private void Carregargrid()
        {
            try
            {
                var listaItensProposta = new DLiItensProposta().Listar().Where(p => p.propostaid == Convert.ToInt32(TxtPropostId.Text)).ToList();
                Dgvmaterial.DataSource = null; Dgvmaterial.DataSource = listaItensProposta;
                Dgvmaterial.Refresh(); MontarGrid(Dgvmaterial); TxtTotalPedido.Text = listaItensProposta.Sum(p => p.total).ToString("C");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGrid(DataGridView dgvmaterial)
        {
            try
            {
                Dgvmaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(Dgvmaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "material", "undmedida", "quantidade", "preco", "m2notafiscal", "obsmaterial", "total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Und Medida", "Quantidade", "Valor", "Qtd Caixa", "Obs Material", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 54, 5, 8, 7, 5, 10, 10 }, Dgvmaterial.Width - 15); //O total tem que ficar em 100% 
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
            dtpDataPrevista.Enabled = Habilitar;
            Rtbmaterial.Enabled = Habilitar;
            BtnSalvarComentario.Enabled = Habilitar;
            BtnImpressao.Enabled = Habilitar;
            DtpDataPedido.Enabled = Habilitar;
            TxtFormaPag.Enabled = Habilitar;
            BtnDeletar.Enabled = Habilitar;
            TxtEngResp.Enabled = Habilitar;
            TxtTelefone.Enabled = Habilitar;
            TxtPdRb.Enabled = Habilitar;
            TxtPdVenda.Enabled = Habilitar;
            TxtProposta.Enabled = Habilitar;
            TxtObra.Enabled = Habilitar;
            RtbComentario.Enabled = Habilitar;
            DtpDataEntrega.Enabled = Habilitar;
            TxtRecebido.Enabled = Habilitar;
            TxtNotaFiscal.Enabled = Habilitar;
            TxtCarreto.Enabled = Habilitar;
            BtnApagar.Enabled = Habilitar;
            BtnCliente.Enabled = Habilitar;
            BtnCodigo.Enabled = Habilitar;
            BtnFabrica.Enabled = Habilitar;
            BtnFaturado.Enabled = Habilitar;
            BtnGravar.Enabled = Habilitar;
            TxtQtd.Enabled = Habilitar;
            TxtPreco.Enabled = Habilitar;
            TxtUndMedida.Enabled = Habilitar;
            RtbObsMaterial.Enabled = Habilitar;
            BtnSalvar.Enabled = Habilitar;
            BtnLimparCampos.Enabled = Habilitar;
            BtnApagar.Enabled = Habilitar;
        }
        private void BtnCriarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new Proposta();
                proposta.statusobraid = 2;//Pendente
                var id = new DLProposta().Inserir(proposta);//inserir
                TxtPropostId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void BtnFabrica_Click(object sender, EventArgs e)
        {
            pesquisar = 1;
            PegarDados_FormCadastroEmpresa();

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
                            TxtCodigoFabrica.Text = id.ToString();
                            TxtFabrica.Text = empresa;
                        }
                        break;
                    case 2:
                        {
                            TxtCodigoFaturado.Text = id.ToString();
                            TxtFaturado.Text = empresa;
                        }
                        break;
                    case 3:
                        {
                            TxtCodigoCliente.Text = id.ToString();
                            TxtEmpresa.Text = empresa;
                        }
                        break;
                }
                cadasEmpr.Close();
                cadasEmpr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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
        private void LimparSalvar()
        {
            dtpDataPrevista.Value = DateTime.Now;
            DtpDataPedido.Value = DateTime.Now;
            TxtFabrica.Text = Convert.ToString(null);
            TxtFaturado.Text = Convert.ToString(null);
            TxtFormaPag.Text = Convert.ToString(null); ;
            TxtEngResp.Text = Convert.ToString(null);
            TxtTelefone.Text = Convert.ToString(null);
            TxtPdRb.Text = Convert.ToString(null);
            TxtPdVenda.Text = Convert.ToString(null);
            TxtProposta.Text = Convert.ToString(null);
            TxtEmpresa.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            RtbComentario.Text = Convert.ToString("Nota Fiscal do material sera enviada por e-mail, qualquer duvida entrar em contato com a Rb Pisos.");
            DtpDataEntrega.Value = DateTime.Now;
            TxtRecebido.Clear();
            TxtNotaFiscal.Clear();
            TxtCarreto.Clear();
            Rtbmaterial.Text = Convert.ToString("Nota Fiscal do material sera enviada por e-mail, qualquer duvida entrar em contato com a Rb Pisos.");
        }
        private bool Validarcampos()
        {
            if (TxtProposta.Text == "")
            {
                throw new Exception(" Informe a Proposta ");
            }
            else if (Rtbmaterial.Text == "")
            {
                throw new Exception("Informe o Material");
            }
            return true;
        }
        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroItens frmCadastroMadeira = new FrmCadastroItens();
                frmCadastroMadeira.ShowDialog();
                var id = frmCadastroMadeira.madeiraid;
                var material = frmCadastroMadeira.material;
                var comprimento = frmCadastroMadeira.comprimento;
                var qtdcaixa = frmCadastroMadeira.qtdcaixa;
                TxtCodigoMaterial.Text = id.ToString();
                TxtMaterial.Text = material;

                Txtm2Caixas.Text = qtdcaixa;
                frmCadastroMadeira.Close();
                frmCadastroMadeira.Dispose();
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
                TxtIItensPropostaId.Text = Convert.ToString(null);
                TxtCodigoMaterial.Text = Convert.ToString(null);
                TxtMaterial.Text = Convert.ToString("Nome do Item ");
                TxtQtd.Text = Convert.ToString(0);
                TxtPreco.Text = Convert.ToString(0);
                Txtm2Caixas.Text = Convert.ToString(0);
                TxtUndMedida.Text = Convert.ToString("m²");
                TxtQtdCaixas.Text = Convert.ToString(0);
                RtbObsMaterial.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private ItensProposta lercampos()
        {
            try
            {
                var iten = new ItensProposta();
                int id = 0;
                int.TryParse(TxtIItensPropostaId.Text, out id);
                if (id == 0)
                {
                    iten.codigomaterial = Convert.ToInt32(TxtCodigoMaterial.Text); iten.material = TxtMaterial.Text;
                    iten.obsmaterial = RtbObsMaterial.Text; iten.quantidade = Convert.ToDecimal(TxtQtd.Text);
                    iten.preco = Convert.ToDecimal(TxtPreco.Text); iten.m2notafiscal = TxtQtdCaixas.Text;
                    iten.undmedida = TxtUndMedida.Text; iten.total = Convert.ToDecimal(TxtTotal.Text);
                    iten.propostaid = Convert.ToInt32(TxtPropostId.Text);
                }
                return iten;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void TxtQtd_TextChanged(object sender, EventArgs e)
        {

            ValorMaterial(); ValorCaixa();

        }
        private void ValorCaixa()
        {
            try
            {
                decimal qtd = 0, caixa = 0, total = 0;
                if (decimal.TryParse(Txtm2Caixas.Text, out qtd))
                {
                    if (decimal.TryParse(TxtQtd.Text, out caixa))
                    {
                        total = caixa / qtd;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                    TxtQtdCaixas.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {
            ValorMaterial();
        }
        private void ValorMaterial()
        {
            try
            {
                decimal qtd = 0, valor = 0, total = 0;
                if (decimal.TryParse(TxtQtd.Text, out qtd))
                {
                    if (decimal.TryParse(TxtPreco.Text, out valor))
                    {
                        total = qtd * valor;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                }
                TxtTotal.Text = total.ToString("N2");
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
                TxtIItensPropostaId.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[0].Value);
                TxtMaterial.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[1].Value);
                TxtUndMedida.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[2].Value);
                Txtm2Caixas.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[3].Value);
                TxtQtd.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[4].Value);
                TxtPreco.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[5].Value);
                TxtQtdCaixas.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[6].Value);
                RtbObsMaterial.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[7].Value);
                TxtTotal.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[8].Value);
                TxtCodigoMaterial.Text = Convert.ToString(Dgvmaterial.Rows[e.RowIndex].Cells[10].Value);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtPropostId.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLProposta().ConsultarPorId(id);
                        pAtua.dataprevista = dtpDataPrevista.Value; pAtua.datapedido = DtpDataPedido.Value;
                        pAtua.fabrica = TxtFabrica.Text; pAtua.faturado = TxtFaturado.Text;
                        pAtua.formapag = TxtFormaPag.Text; pAtua.engresp = TxtEngResp.Text;
                        pAtua.telefone = TxtTelefone.Text; pAtua.pdrb = TxtPdRb.Text;
                        pAtua.pdvenda = TxtPdVenda.Text; pAtua.propostaa = TxtProposta.Text;
                        pAtua.construtora = TxtEmpresa.Text; pAtua.obra = TxtObra.Text;
                        pAtua.dataentrega = DtpDataEntrega.Value;
                        pAtua.recebidopor = TxtRecebido.Text; pAtua.notafiscal = TxtNotaFiscal.Text;
                        pAtua.carreto = TxtCarreto.Text; pAtua.material = Rtbmaterial.Text;
                        if (RbImediato.Checked == true)
                            pAtua.statusobraid = 1;
                        else if (RbPendente.Checked == true)
                            pAtua.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            pAtua.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            pAtua.statusobraid = 4;
                        new DLProposta().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparSalvar();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private Historico lercomentario()
        {
            try
            {
                var iten = new Historico();
                int id = 0;
                int.TryParse(TxtHistorico.Text, out id);
                if (id == 0)
                {
                    iten.comentario = RtbComentario.Text;
                    iten.datacomentario = DtpHistorico.Value;
                    iten.propostaid = Convert.ToInt32(TxtPropostId.Text);
                }
                return iten;
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
                ReportDataSource rs = new ReportDataSource();
                List<ItensProposta> lst = new List<ItensProposta>();
                lst.Clear();
                for (int i = 0; i < Dgvmaterial.Rows.Count - 0; i++)
                {
                    lst.Add(new ItensProposta
                    {
                        itenid = int.Parse(Dgvmaterial.Rows[i].Cells[0].Value.ToString()),
                        material = Dgvmaterial.Rows[i].Cells[1].Value.ToString(),
                        undmedida = Dgvmaterial.Rows[i].Cells[2].Value.ToString(),
                        quantidade = Convert.ToDecimal(Dgvmaterial.Rows[i].Cells[4].Value.ToString()),
                        m2notafiscal = Dgvmaterial.Rows[i].Cells[6].Value.ToString(),
                    });
                }
                rs.Name = "DataSet";
                rs.Value = lst;
                #endregion

                #region Tabela Historico de Comentario
                ReportDataSource hs = new ReportDataSource();
                List<Historico> histo = new List<Historico>();
                histo.Clear();
                for (int i = 0; i < DgvHistorico.Rows.Count - 0; i++)
                {
                    histo.Add(new Historico
                    {
                        historicoid = int.Parse(DgvHistorico.Rows[i].Cells[0].Value.ToString()),
                        comentario = DgvHistorico.Rows[i].Cells[2].Value.ToString(),
                        datacomentario = Convert.ToDateTime(DgvHistorico.Rows[i].Cells[1].Value.ToString()),
                    });
                }
                hs.Name = "Historico";
                hs.Value = histo;
                #endregion
                FrmImpressao frmImpressao = new FrmImpressao(DtpDataEntrega.Value, TxtProposta.Text, TxtEmpresa.Text, TxtObra.Text, rs, TxtNotaFiscal.Text, RtbComentario.Text, hs);
                frmImpressao.reportViewer1.LocalReport.DataSources.Clear();
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(rs);
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(hs);
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
                        if (listaUsuarios[i].senhass == login.TxtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int ide = 0;
                        int.TryParse(TxtPropostId.Text, out ide);
                        if (ide > 0)
                        {
                            new DLProposta().Excluir(new Proposta { propostaid = ide });
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
                var itenproposta = lercampos();
                int ItensPropostaId = 0;
                if (TxtIItensPropostaId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtIItensPropostaId.Text);
                }
                int propostaid = 0;
                if (TxtPropostId.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtPropostId.Text);
                }
                var listaProposta = new DLiItensProposta().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.propostaid == propostaid //por proppostaid
                                && ip.itenid == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.itenid > 0)
                {

                    prop.m2caixa = Convert.ToDecimal(Txtm2Caixas.Text);
                    prop.m2notafiscal = TxtQtdCaixas.Text;
                    prop.material = TxtMaterial.Text;
                    prop.preco = Convert.ToDecimal(TxtPreco.Text);
                    prop.quantidade = Convert.ToDecimal(TxtQtd.Text);
                    prop.obsmaterial = RtbObsMaterial.Text;
                    prop.undmedida = TxtUndMedida.Text;
                    prop.total = Convert.ToDecimal(TxtTotal.Text);
                    new DLiItensProposta().Atualizar(prop);
                }
                else
                {
                    new DLiItensProposta().Inserir(itenproposta);
                }
                LimparCamposItens();
                Carregargrid();
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
                int.TryParse(TxtIItensPropostaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLiItensProposta().ConsultarPorId(id);
                    if (prop.itenid > 0)
                    {
                        new DLiItensProposta().Excluir(prop);
                        Carregargrid(); LimparCamposItens();
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
                var comentario = lercomentario();
                int historicoComentario = 0;
                if (TxtHistorico.Text != "")
                {
                    historicoComentario = Convert.ToInt32(TxtHistorico.Text);
                }
                int propostaid = 0;
                if (TxtPropostId.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtPropostId.Text);
                }
                var listaProposta = new DLHistorico().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.propostaid == propostaid //por proppostaid
                                && ip.historicoid == historicoComentario //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.historicoid > 0)
                {
                    prop.comentario = RtbComentario.Text;
                    prop.datacomentario = DtpHistorico.Value;
                    new DLHistorico().Atualizar(prop);
                }
                else
                {
                    new DLHistorico().Inserir(comentario);
                }
                carregarhistorico();
                RtbComentario.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LiberarSalvamentoComentario(bool verdadeiro)
        {
            BtnSalvarComentario.Enabled = verdadeiro;
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
                int.TryParse(TxtHistorico.Text, out id);
                if (id > 0)
                {
                    var prop = new DLHistorico().ConsultarPorId(id);
                    if (prop.historicoid > 0)
                    {
                        new DLHistorico().Excluir(prop);
                        TxtHistorico.Clear();
                        carregarhistorico();
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
            TxtHistorico.Clear();
            RtbComentario.Clear();
            carregarhistorico();
        }
        private void DgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtHistorico.Text = Convert.ToString(DgvHistorico.Rows[e.RowIndex].Cells[0].Value);
                RtbComentario.Text = Convert.ToString(DgvHistorico.Rows[e.RowIndex].Cells[2].Value);
                DtpHistorico.Value = Convert.ToDateTime(DgvHistorico.Rows[e.RowIndex].Cells[1].Value);
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
        private void TxtCodigoFabrica_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TxtCodigoFabrica.Text, out int idempresa))
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(TxtCodigoFabrica.Text));
                    TxtCodigoFabrica.Text = _fabrica.empresaid.ToString();
                    TxtFabrica.Text = _fabrica.empresa;
                }
                else
                {
                    TxtCodigoFabrica.Text = Convert.ToString(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoFaturado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TxtCodigoFaturado.Text, out int idempresa))
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(TxtCodigoFaturado.Text));
                    TxtCodigoFaturado.Text = _fabrica.empresaid.ToString();
                    TxtFaturado.Text = _fabrica.empresa;
                }
                else
                {
                    TxtCodigoFaturado.Text = Convert.ToString(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TxtCodigoCliente.Text, out int idempresa))
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(TxtCodigoCliente.Text));
                    TxtCodigoCliente.Text = _fabrica.empresaid.ToString();
                    TxtEmpresa.Text = _fabrica.empresa;
                }
                else
                {
                    TxtCodigoCliente.Text = Convert.ToString(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtCodigoMaterial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TxtCodigoMaterial.Text, out int idempresa))
                {
                    _madeira = new DLCadastrarMadeira().ConsultarPorId(Convert.ToInt32(TxtCodigoMaterial.Text));
                    TxtCodigoMaterial.Text = _madeira.madeiraid.ToString();
                    TxtMaterial.Text = _madeira.pisomadeira;
                    Txtm2Caixas.Text = Convert.ToString(_madeira.m2caixa);
                }
                else
                {
                    TxtCodigoMaterial.Text = Convert.ToString(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
