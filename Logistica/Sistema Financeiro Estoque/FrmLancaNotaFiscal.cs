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
        internal proposta _notafiscal;
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
                    _notafiscal = new proposta();
                if (_notafiscal.idprop > 0)
                {
                    HabilitarCampos(true);
                    _notafiscal = new DLproposta().ConsultarPorId(_notafiscal.idprop);
                    TxtGerarId.Text = _notafiscal.idprop.ToString();
                    DataEmissao.Value = _notafiscal.emissaonf;
                    DataVencimento.Value = _notafiscal.vencimentonf;
                    TxtObra.Text = _notafiscal.obra;
                    TxtCliente.Text = _notafiscal.cliente;
                    TxtProposta.Text = _notafiscal.propostas;
                    TxtNotaFiscal.Text = _notafiscal.notafiscal;
                    RtbComentario.Text = _notafiscal.cometario;
                    switch (_notafiscal.statusobraid)//escolha
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
        private void CarregarMadeira()
        {
            try
            {
                var listarmadeira = new DLitensmadeira().Listar().Where(p => p.idprop == Convert.ToInt32(TxtGerarId.Text)).ToList();
                DgvMadeiras.DataSource = null; DgvMadeiras.DataSource = listarmadeira;
                DgvMadeiras.Refresh(); montarmadeira(DgvMadeiras);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void montarmadeira(DataGridView dgvMadeiras)
        {
            try
            {
                DgvMadeiras.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMadeiras);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "madeiras", "medida", "total", });
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
        private void BtnCriarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new proposta();
                proposta.statusobraid = 2;//Pendente
                var id = new DLproposta().Inserir(proposta);//inserir
                TxtGerarId.Text = id.ToString();
                bloquear(false);           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void bloquear(bool desabilitar)
        {
            BtnCriarProposta.Enabled = desabilitar;
        }
        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClienteFinanceiro cliente = new FrmClienteFinanceiro(); cliente.ShowDialog();
                var idcliente = cliente.idcliente; var nome = cliente.nome;
                var email = cliente.email;
                TxtCodigo.Text = idcliente.ToString(); TxtCliente.Text = nome.ToString();
                cliente.Close(); cliente.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }      
        private void limparSalvar()
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
                TxtCodigoMadeira.Text = id.ToString();
                Txtmadeiras.Text = madeirass;
                TxtMedidaMadeira.Text = medida;
                TxtSaidaMadeira.Text = Convert.ToString(total);
                Fmadeira.Close();
                Fmadeira.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }     
        private itensmadeira lercamposmadeira()
        {
            var iten = new itensmadeira();
            try
            {
                int id = 0;
                int.TryParse(TxtIdMadeira.Text, out id);
                if (id == 0)
                {
                    iten.madeiras = Txtmadeiras.Text;
                    iten.medida = TxtMedidaMadeira.Text;
                    iten.total = Convert.ToDecimal(TxtSaidaMadeira.Text);
                    iten.idprop = Convert.ToInt32(TxtGerarId.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iten;
        }    
        private void Limparmadeira()
        {            
            Txtmadeiras.Text = Convert.ToString("MADEIRAS");
            TxtMedidaMadeira.Text = Convert.ToString("UND MEDIDA");
            TxtSaidaMadeira.Text = Convert.ToString("SAIDA");
            TxtIdMadeira.Text = Convert.ToString(null);
        }
        private void DgvMadeiras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdMadeira.Text = Convert.ToString(DgvMadeiras.Rows[e.RowIndex].Cells[0].Value);
                Txtmadeiras.Text = Convert.ToString(DgvMadeiras.Rows[e.RowIndex].Cells[2].Value);
                TxtMedidaMadeira.Text = Convert.ToString(DgvMadeiras.Rows[e.RowIndex].Cells[3].Value);
                TxtSaidaMadeira.Text = Convert.ToString(DgvMadeiras.Rows[e.RowIndex].Cells[4].Value);
                TxtCodigoMadeira.Text = Convert.ToString(DgvMadeiras.Rows[e.RowIndex].Cells[5].Value);
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
                var itenproposta = lercamposmadeira();
                int ItensPropostaId = 0;
                if (TxtIdMadeira.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtIdMadeira.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtGerarId.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtGerarId.Text);
                }
                var listarmadeira = new DLitensmadeira().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.idprop == propostaid //por proppostaid
                                && ip.idmadeira == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.idmadeira > 0)
                {
                    prop.codigo = Convert.ToInt32(TxtCodigoMadeira.Text);
                    prop.madeiras = Txtmadeiras.Text;
                    prop.medida = TxtMedidaMadeira.Text;
                    prop.total = Convert.ToDecimal(TxtSaidaMadeira.Text);
                    new DLitensmadeira().Atualizar(prop);
                }
                else
                {
                    new DLitensmadeira().Inserir(itenproposta);
                    MessageBox.Show("Item Cadastrado com Sucesso");
                }
                Limparmadeira();
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
                    int.TryParse(TxtIdMadeira.Text, out id);
                    if (id > 0)
                    {
                        var prop = new DLitensmadeira().ConsultarPorId(id);
                        if (prop.idmadeira > 0)
                        {
                            new DLitensmadeira().Excluir(prop);
                            CarregarMadeira(); Limparmadeira();
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
            try
            {
                Limparmadeira();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
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
                        var pAtua = new DLproposta().ConsultarPorId(id);
                        pAtua.emissaonf = DataEmissao.Value; pAtua.vencimentonf = DataVencimento.Value;
                        pAtua.cliente = TxtCliente.Text; 
                        pAtua.propostas = TxtProposta.Text; pAtua.notafiscal = TxtNotaFiscal.Text;
                        pAtua.obra = TxtObra.Text; pAtua.cometario = RtbComentario.Text;
                        if (RbEngenharia.Checked == true)
                            pAtua.statusobraid = 1;
                        else if (RbComercio.Checked == true)
                            pAtua.statusobraid = 2;
                        else if (RbPisos.Checked == true)
                            pAtua.statusobraid = 3;
                        new DLproposta().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        limparSalvar();
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
                        new DLproposta().Excluir(new proposta { idprop = id });
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
    }
}
