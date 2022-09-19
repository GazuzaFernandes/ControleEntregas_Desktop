using DALFinanceiro.Entities;
using DALFinanceiro.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_Financeiro_Estoque
{
    public partial class FrmLancaNotaFiscal : Form
    {
        internal Proposta _notafiscal;
        public FrmLancaNotaFiscal()
        {
            InitializeComponent();
        }
        private void FrmLancaNotaFiscal_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                HabilitarCampos(false);
                if (_notafiscal == null)
                    _notafiscal = new Proposta();
                if (_notafiscal.IdProp > 0)
                {
                    HabilitarCampos(true);
                    _notafiscal = new DLProposta().ConsultarPorId(_notafiscal.IdProp);
                    TxtGerarId.Text = _notafiscal.IdProp.ToString();
                    DataEmissao.Value = _notafiscal.EmissaoNf;
                    DataVencimento.Value = _notafiscal.VencimentoNf;
                    TxtObra.Text = _notafiscal.Obra;
                    TxtCliente.Text = _notafiscal.Cliente;
                    TxtProposta.Text = _notafiscal.Propostas;
                    TxtNotaFiscal.Text = _notafiscal.Notafiscal;
                    RtbComentario.Text = _notafiscal.Cometario;
                    switch (_notafiscal.StatusobraId)//escolha
                    {
                        case 1:
                            {
                                RbEngenharia.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                RbComercio.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                RbPisos.Checked = true;
                            }
                            break;
                    }
                    CarregarMadeira();                
                }
                else
                {
                    RbEngenharia.Checked = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Apenas Metodos

        private void CarregarMadeira()
        {
            try
            {
                var listarMadeira = new DLItensmadeira().Listar().Where(p => p.IdProp == Convert.ToInt32(TxtGerarId.Text)).ToList();
                DgvMadeiras.DataSource = null; DgvMadeiras.DataSource = listarMadeira;
                DgvMadeiras.Refresh(); MontarGridMadeira(DgvMadeiras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridMadeira(DataGridView dgvMadeiras)
        {
            try
            {
                DgvMadeiras.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMadeiras);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Madeiras", "Medida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeiras", "Unidade de Medida", "Saida Total", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 60, 20, 20, }, DgvMadeiras.Width - 15); //O total tem que ficar em 100% 
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
        private void HabilitarCampos(bool habilitar)
        {
            DataEmissao.Enabled = habilitar;
            DataVencimento.Enabled = habilitar;
            TxtProposta.Enabled = habilitar;
            TxtNotaFiscal.Enabled = habilitar;
            TxtObra.Enabled = habilitar;
        }
        private void Bloquear(bool desabilitar)
        {
            BtnCriarProposta.Enabled = desabilitar;
        }
        private void LimparSalvar()
        {
            TxtCliente.Text = Convert.ToString(null);
            TxtProposta.Text = Convert.ToString(null);
            TxtNotaFiscal.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            RtbComentario.Text = Convert.ToString(null);
        }
        private bool Validarcampos()
        {
            return true;
        }
        private Itensmadeira lercamposmadeira()
        {
            var iten = new Itensmadeira();
            try
            {
                int id = 0;
                int.TryParse(txtIdMadeira.Text, out id);
                if (id == 0)
                {
                    iten.Madeiras = txtmadeiras.Text;
                    iten.Medida = txtMedidaMadeira.Text;
                    iten.Total = Convert.ToDecimal(txtSaidaMadeira.Text);
                    iten.IdProp = Convert.ToInt32(TxtGerarId.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iten;
        }
        private void LimparMadeira()
        {
            txtmadeiras.Text = Convert.ToString("MADEIRAS");
            txtMedidaMadeira.Text = Convert.ToString("UND MEDIDA");
            txtSaidaMadeira.Text = Convert.ToString("SAIDA");
            txtIdMadeira.Text = Convert.ToString(null);
           txtCodigoMadeira.Text = Convert.ToString(0);
        }

        #endregion

        #region Tela Proposta
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtGerarId.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLProposta().ConsultarPorId(id);
                        pAtua.EmissaoNf = DataEmissao.Value; pAtua.VencimentoNf = DataVencimento.Value;
                        pAtua.Cliente = TxtCliente.Text;
                        pAtua.Propostas = TxtProposta.Text; pAtua.Notafiscal = TxtNotaFiscal.Text;
                        pAtua.Obra = TxtObra.Text; pAtua.Cometario = RtbComentario.Text;
                        if (RbEngenharia.Checked == true)
                            pAtua.StatusobraId = 1;
                        else if (RbComercio.Checked == true)
                            pAtua.StatusobraId = 2;
                        else if (RbPisos.Checked == true)
                            pAtua.StatusobraId = 3;
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
        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente deletar a Proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtGerarId.Text, out id);
                    if (id > 0)
                    {
                        new DLProposta().Excluir(new Proposta { IdProp = id });
                        MessageBox.Show("Proposta excluída com sucesso!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClienteFinanceiro cliente = new FrmClienteFinanceiro(); 
                cliente.ShowDialog();
                var idcliente = cliente.idcliente; 
                var nome = cliente.nome;
                var email = cliente.email;
                txtCodigoCliente.Text = idcliente.ToString(); 
                TxtCliente.Text = nome.ToString();
                cliente.Close(); 
                cliente.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnCriarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new Proposta();
                proposta.StatusobraId = 2;//Pendente
                var id = new DLProposta().Inserir(proposta);//inserir
                TxtGerarId.Text = id.ToString();
                Bloquear(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #endregion

        #region Tela Itens da Proposta
        private void BtnPesquisarMadeira_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoqueFinanceiro Fmadeira = new FrmEstoqueFinanceiro();
                Fmadeira.ShowDialog();
                var id = Fmadeira.idmadeira;
                var madeirass = Fmadeira.madeirass;
                var medida = Fmadeira.medida;
                var total = Fmadeira.total;
                txtCodigoMadeira.Text = id.ToString();
                txtmadeiras.Text = madeirass;
                txtMedidaMadeira.Text = medida;
                txtSaidaMadeira.Text = Convert.ToString(total);
                Fmadeira.Close();
                Fmadeira.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvMadeiras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var listarMadeira = DgvMadeiras.Rows[e.RowIndex].DataBoundItem as Itensmadeira;
                if(listarMadeira != null)
                {
                    txtIdMadeira.Text = listarMadeira.IdMadeira.ToString();
                    txtmadeiras.Text = listarMadeira.Madeiras;
                    txtMedidaMadeira.Text = listarMadeira.Medida;
                    txtSaidaMadeira.Text = listarMadeira.Total.ToString();
                    txtCodigoMadeira.Text = listarMadeira.Codigo.ToString();
                }           
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var itensMadeira = lercamposmadeira();
                int itensFormNotaFiscal = 0;
                if (txtIdMadeira.Text != "")
                {
                    itensFormNotaFiscal = Convert.ToInt32(txtIdMadeira.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtGerarId.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtGerarId.Text);
                }
                var listarmadeira = new DLItensmadeira().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.IdProp == propostaid //por proppostaid
                                && ip.IdMadeira == itensFormNotaFiscal //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.IdMadeira > 0)
                {
                    prop.Codigo = Convert.ToInt32(txtCodigoMadeira.Text);
                    prop.Madeiras = txtmadeiras.Text;
                    prop.Medida = txtMedidaMadeira.Text;
                    prop.Total = Convert.ToDecimal(txtSaidaMadeira.Text);
                    new DLItensmadeira().Atualizar(prop);
                }
                else
                {
                    new DLItensmadeira().Inserir(itensMadeira);                 
                }
                LimparMadeira();
                CarregarMadeira();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente deletar o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdMadeira.Text, out id);
                    if (id > 0)
                    {
                        var prop = new DLItensmadeira().ConsultarPorId(id);
                        if (prop.IdMadeira > 0)
                        {
                            new DLItensmadeira().Excluir(prop);
                            CarregarMadeira(); LimparMadeira();
                        }
                        else
                        {
                            MessageBox.Show("id Invalido");
                        }
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
            LimparMadeira();
        }

        #endregion
    }
}
