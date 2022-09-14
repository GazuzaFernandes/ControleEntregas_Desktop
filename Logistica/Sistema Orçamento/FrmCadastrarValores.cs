using DALOrcamento.Entities;
using DALOrcamento.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_Controle_de_Preços
{
    public partial class FrmCadastrarValores : Form
    {
        internal Produtos _produto;
        public FrmCadastrarValores()
        {
            InitializeComponent();
        }
        private void FrmCadastrarValores_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                if (_produto == null)
                    _produto = new Produtos();
                if (_produto.ProdutoId > 0)
                {
                    HabilitarCampos(true);
                    _produto = new DLProdutos().ConsultarPorId(_produto.ProdutoId);
                    txtIdProduto.Text = _produto.ProdutoId.ToString();
                    txtFonrcedor.Text = _produto.Fornecedor;
                    txtPreco.Text = _produto.Preco;
                    txtProduto.Text = _produto.Produto;
                    txtRendimento.Text = _produto.Rendimento;
                    rtbComentario.Text = _produto.Comentario;
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var produtos = new Produtos();
                var id = new DLProdutos().Inserir(produtos);//inserir
                txtIdProduto.Text = id.ToString();
                BloquearGeradorId(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvDatas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var datas = DgvDatas.Rows[e.RowIndex].DataBoundItem as DataProduto;
            if (datas != null)
            {
                txtDataId.Text = datas.ProdutoId.ToString();
                dtpAtualizado.Value = datas.Data;
                txtPreco.Text = datas.Preco;
            }           
        }
        private void BtnSalvarDatas_Click(object sender, EventArgs e)
        {
            try
            {
                var dataproduto = LerData();
                int valorProdutoData = 0;
                if (txtDataId.Text != "")
                {
                    valorProdutoData = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtIdProduto.Text != "")
                {
                    propostaid = Convert.ToInt32(txtIdProduto.Text);
                }
                var listarmadeira = new DLDataProduto().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.ProdutoId == propostaid //por proppostaid
                                && ip.DataId == valorProdutoData //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.DataId > 0)
                {
                    prop.DataId = Convert.ToInt32(txtDataId.Text);
                    prop.Data = dtpAtualizado.Value;
                    prop.Preco = txtPreco.Text;
                    new DLDataProduto().Atualizar(prop);
                }
                else
                {
                    new DLDataProduto().Inserir(dataproduto);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }
                LiberarSalvar(true);
                CarregarGrid();
                txtDataId.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Já Fez o Cadastro da Data primeiro ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool camposSaoValidos = Validarcampos();
                    if (camposSaoValidos == true)
                    {
                        int id = 0;
                        int.TryParse(txtIdProduto.Text, out id);
                        if (id > 0)
                        {
                            var valorNovo = new DLProdutos().ConsultarPorId(id);
                            valorNovo.Produto = txtProduto.Text;
                            valorNovo.Fornecedor = txtFonrcedor.Text;
                            valorNovo.Preco = txtPreco.Text;
                            valorNovo.Rendimento = txtRendimento.Text;
                            valorNovo.Comentario = rtbComentario.Text;
                            new DLProdutos().Atualizar(valorNovo);
                            MessageBox.Show("Material atualizado com Sucesso ");
                            LimparCampos();
                            Close();
                            DgvDatas.DataSource = null;
                        }
                    }
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
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdProduto.Text, out id);
                    if (id > 0)
                    {
                        new DLProdutos().Excluir(new Produtos { ProdutoId = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtIdProduto.Text = Convert.ToString(null);
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
        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void BtnDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir essa Data ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtDataId.Text, out id);
                    if (id > 0)
                    {
                        new DLDataProduto().Excluir(new DataProduto { DataId = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtDataId.Text = Convert.ToString(null);

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

        #region Apenas Metodos
        private void LiberarSalvar(bool habilitar)
        {
            BtnSalvarProduto.Enabled = habilitar;
        }
        private void CarregarGrid()
        {
            try
            {
                var listar = new DLDataProduto().Listar().Where(p => p.ProdutoId == Convert.ToInt32(txtIdProduto.Text)).ToList();
                DgvDatas.DataSource = null;
                DgvDatas.DataSource = listar.OrderByDescending(p => p.Data).ToList();
                DgvDatas.Refresh();
                MontarGridData(DgvDatas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridData(object dgvDatas)
        {
            DgvDatas.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvDatas);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Data", "Preco" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data da Atualização", "Valor" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 40, 40, }, DgvDatas.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private DataProduto LerData()
        {
            try
            {
                var data = new DataProduto();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    data.Data = dtpAtualizado.Value;
                    data.Preco = txtPreco.Text;
                    data.ProdutoId = Convert.ToInt32(txtIdProduto.Text);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            txtFonrcedor.Text = Convert.ToString(null);
            txtDataId.Text = Convert.ToString(null);
            txtIdProduto.Text = Convert.ToString(null);
            txtPreco.Text = Convert.ToString(null);
            txtProduto.Text = Convert.ToString(null);
            txtRendimento.Text = Convert.ToString(null);
            rtbComentario.Text = Convert.ToString(null);
        }
        private void BloquearGeradorId(bool desabilitar)
        {
            btnGerarIdProduto.Enabled = desabilitar;
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtFonrcedor.Enabled = habilitar;
            txtPreco.Enabled = habilitar;
            txtProduto.Enabled = habilitar;
            txtRendimento.Enabled = habilitar;
            BtnSalvarDatas.Enabled = habilitar;
            BtnDeletar.Enabled = habilitar;
            BtnLimpar.Enabled = habilitar;
        }
        #endregion
    }
}
