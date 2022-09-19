using DALOrcamento.Entities;
using DALOrcamento.Repository;
using DALSenhas.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Logistica.Sistema_Controle_de_Preços
{
    public partial class FrmPrincpalValores : Form
    {
        public FrmPrincpalValores()
        {
            InitializeComponent();
        }
        private void FrmPrincpalValores_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProp = new DLProdutos().Listar();
                CarregarGridProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Apenas Botões
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarValores cadastrar = new FrmCadastrarValores();
            cadastrar.ShowDialog();
            CarregarGridProdutos();
        }
        private void BtnLimparPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString("Digite para Pesquisar");
            CarregarGridProdutos();
        }
        #endregion

        #region Apenas Text Box
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGridProdutos(true);
            MontarGridProdutos(DgvValores);
        }
        #endregion

        #region Apenas Metodos
        private void CarregarGridProdutos(bool isPesquisa = false)
        {
            try
            {
                var listarProdutos = new DLProdutos().Listar();
                var pesquisa = txtPesquisar.Text;

                listarProdutos = listarProdutos.Where(p => p.Produto.ToLower().Contains(pesquisa)).ToList();

                DgvValores.DataSource = listarProdutos.OrderBy(p => p.Fornecedor).ToList();
                MontarGridProdutos(DgvValores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridProdutos(DataGridView dgvValores)
        {
            DgvValores.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvValores);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Fornecedor", "Produto", "Preco", "Rendimento", "Comentario" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Fornecedor", "Produto", "Preço", "Rendimento", "Descrição" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 35, 20, 10, 20 }, DgvValores.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion
        private void DgvValores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var produtos = new Produtos();
                produtos.ProdutoId = Convert.ToInt32(DgvValores.Rows[e.RowIndex].Cells[0].Value);
                FrmCadastrarValores vaalores = new FrmCadastrarValores();
                vaalores._produto = produtos;
                vaalores.ShowDialog();
                CarregarGridProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void FrmPrincpalValores_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FunctionsDataBase.BackupDatabase(
                                                  "192.168.1.228",
                                                  "5432",
                                                  "postgres",
                                                  "q1s2e3f4t5",
                                                  "RBORCAMENTO",
                                               $@"F:\_LOGISTICA\Restauração\SistemaControle\{ DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                                  @"SistemaControle");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
