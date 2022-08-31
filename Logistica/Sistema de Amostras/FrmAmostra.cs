using DALLogistica.Entities;
using DALLogistica.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_de_Amostras
{
    public partial class FrmAmostra : Form
    {
        internal Amostra _amostracliente;
        public FrmAmostra()
        {
            InitializeComponent();
        }
        private void FrmAmostra_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                if (_amostracliente == null)
                    _amostracliente = new Amostra();
                if (_amostracliente.AmostraId > 0)
                {
                    HabilitarCampos(true);
                    _amostracliente = new DLAmostra().ConsultarPorId(_amostracliente.AmostraId);
                    txtAmostraId.Text = _amostracliente.AmostraId.ToString();
                    dtpDataentrega.Value = _amostracliente.DataEntrega;
                    rtbComentario.Text = _amostracliente.Material;
                    txtConstrutora.Text = _amostracliente.Construtora;
                    txtObra.Text = _amostracliente.Obra;
                    switch (_amostracliente.StatusobraId)//escolha
                    {
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
                    BloquearBotao(false);
                    CarregarGrid();
                }
                else
                {
                    rbPendente.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                var listaamostra = new DLItensAmostra().Listar().Where(p => p.AmostraId == Convert.ToInt32(txtAmostraId.Text)).ToList();
                DgvAmostra.DataSource = null; 
                DgvAmostra.DataSource = listaamostra;
                DgvAmostra.Refresh(); 
                MontarGrid(DgvAmostra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGrid(DataGridView dgvAmostra)
        {
            try
            {
                DgvAmostra.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvAmostra);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Codigo", "Material", "Quantidade", "Observacao", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Codigo", "Material", "Quantidade", "Observãção", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 10, 64, 10, 10 }, DgvAmostra.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
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
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLAmostra().ConsultarPorId(id);
                        atualizar.DataEntrega = dtpDataentrega.Value;
                        atualizar.Construtora = txtConstrutora.Text;
                        atualizar.Obra = txtObra.Text;
                        atualizar.Material = rtbComentario.Text;
                        if (rbPendente.Checked == true)
                            atualizar.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            atualizar.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            atualizar.StatusobraId = 4;
                        new DLAmostra().Atualizar(atualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                        LimparAmostra();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private bool ValidarCampos()
        {
            if (txtConstrutora.Text == "")
            {
                throw new Exception("Informe o Cliente");
            }
            else if (rtbComentario.Text == "")
            {
                throw new Exception("Informe o material");
            }
            return true;
        }
        private void LimparAmostra()
        {
            dtpDataentrega.Value = DateTime.Now;
            txtConstrutora.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa Amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        new DLAmostra().Excluir(new Amostra { AmostraId = id });
                        MessageBox.Show("Amostra excluída com sucesso!");
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
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoqueAmostra estoqueAmostra = new FrmEstoqueAmostra();
                estoqueAmostra.ShowDialog();

                var itensamostraid = estoqueAmostra.itensamostraid;
                var material = estoqueAmostra.material;
                var quantidade = estoqueAmostra.quantidade;

                txtCodigoMadeira.Text = itensamostraid.ToString();
                txtMaterial.Text = material;
                txtSaidaMadeira.Text = quantidade.ToString();
                estoqueAmostra.Close();
                estoqueAmostra.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var itensamostra = Lercampos();
                int ItensPropostaId = 0;
                if (txtTabelaId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(txtTabelaId.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtAmostraId.Text != "")
                {
                    propostaid = Convert.ToInt32(txtAmostraId.Text);
                }
                var listaProposta = new DLItensAmostra().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.AmostraId == propostaid //por proppostaid
                                && ip.ItensamostraId == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.ItensamostraId > 0)
                {
                    prop.Codigo = Convert.ToInt32(txtCodigoMadeira.Text);
                    prop.Material = txtMaterial.Text;
                    prop.Observacao = txtObservacao.Text;
                    prop.Quantidade = Convert.ToDecimal(txtSaidaMadeira.Text);
                    new DLItensAmostra().Atualizar(prop);
                }
                else
                {
                    new DLItensAmostra().Inserir(itensamostra);
                }
                SalvarComentario();
                LimparCamposItens();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void SalvarComentario()
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLItensAmostra().ConsultarPorId(id);
                        atualizar.Material = rtbComentario.Text;
                        new DLItensAmostra().Inserir(atualizar);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private ItensAmostra Lercampos()
        {
            try
            {
                var iten = new ItensAmostra();
                int id = 0;
                int.TryParse(txtTabelaId.Text, out id);
                if (id == 0)
                {
                    iten.Codigo = Convert.ToInt32(txtCodigoMadeira.Text);
                    iten.Material = txtMaterial.Text;
                    iten.Observacao = txtObservacao.Text;
                    iten.Quantidade = Convert.ToDecimal(txtSaidaMadeira.Text);
                    iten.AmostraId = Convert.ToInt32(txtAmostraId.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtTabelaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLItensAmostra().ConsultarPorId(id);
                    if (prop.ItensamostraId > 0)
                    {
                        new DLItensAmostra().Excluir(prop);
                        CarregarGrid();
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
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
        }
        private void LimparCamposItens()
        {
            txtTabelaId.Text = Convert.ToString(null);
            txtCodigoMadeira.Text = Convert.ToString(null);
            txtMaterial.Text = Convert.ToString(null);
            txtSaidaMadeira.Text = Convert.ToString(null);
            txtObservacao.Text = Convert.ToString(null);
        }
        private void BtnGerarAmostra_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var amostra = new Amostra();
                amostra.StatusobraId = 2;//Pendente
                var id = new DLAmostra().Inserir(amostra);//inserir
                txtAmostraId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BloquearBotao(bool bloquear)
        {
            btnGerarAmostra.Enabled = bloquear;
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtConstrutora.Enabled = habilitar;
            txtObra.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            txtObservacao.Enabled = habilitar;
            btnPesquisar.Enabled = habilitar;
            btnInserir.Enabled = habilitar;
            btnApagar.Enabled = habilitar;
            btnLimpar.Enabled = habilitar;
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var itensAmostra = DgvAmostra.Rows[e.RowIndex].DataBoundItem as ItensAmostra;
                if( itensAmostra != null)
                {
                    txtTabelaId.Text = itensAmostra.AmostraId.ToString();
                    txtCodigoMadeira.Text = Convert.ToString(itensAmostra.Codigo);
                    txtMaterial.Text = itensAmostra.Material;
                    txtSaidaMadeira.Text = Convert.ToString(itensAmostra.Quantidade); 
                    txtObservacao.Text = itensAmostra.Observacao;
                }              
                HabilitarCampos(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
