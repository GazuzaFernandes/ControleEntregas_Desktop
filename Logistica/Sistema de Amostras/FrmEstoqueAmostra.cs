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
    public partial class FrmEstoqueAmostra : Form
    {
        public int itensamostraid;
        public int codigo;
        public string material;
        public decimal quantidade;
        internal EstoqueAmostra _estoque;
        public FrmEstoqueAmostra()
        {
            InitializeComponent();
        }
        private void FrmEstoqueAmostra_Load(object sender, EventArgs e)
        {        
            CarregarGrid();
            HabilitarCampos(false);
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtAmostra.Enabled = habilitar;
            txtEntrada.Enabled = habilitar;
            btnSalvarMaterial.Enabled = habilitar;
            btnDeletarMaterial.Enabled = habilitar;
            btnLimparTudo.Enabled = habilitar;
            txtSaida.Enabled = habilitar;
            btnSelecionar.Enabled = habilitar;
            btnLimparMaterial.Enabled = habilitar;
        }
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var estoqueAmostras = new DLEstoqueAmostra().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    estoqueAmostras = estoqueAmostras.Where(p => p.Amostra.ToLower().Contains(pesquisa)).ToList();
                }
                DgvEstoqueAmostra.DataSource = estoqueAmostras.OrderBy(p => p.Total).ToList();
                MontarGrid(DgvEstoqueAmostra);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvEstoqueAmostra)
        {
            try
            {
                DgvEstoqueAmostra.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvEstoqueAmostra);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Amostra", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Amostra", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 82, 10 }, DgvEstoqueAmostra.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtCadastrarAmostra.Text, out id);
                    if (id > 0)
                    {
                        var estoqueAt = new DLEstoqueAmostra().ConsultarPorId(id);
                        estoqueAt.EstoqueId = Convert.ToInt32(txtCadastrarAmostra.Text);
                        estoqueAt.Amostra = txtAmostra.Text;
                        estoqueAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                        estoqueAt.Total = Convert.ToDecimal(txtTotalEntrada.Text);
                        new DLEstoqueAmostra().Atualizar(estoqueAt);
                        MessageBox.Show("Estoque atualizado com Sucesso ");
                        LimparCampos();
                        CarregarGrid();
                        HabilitarCampos(false);
                        BloquearBotao(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            txtCadastrarAmostra.Text = Convert.ToString(null);
            txtAmostra.Text = Convert.ToString(null);
            txtEntrada.Text = Convert.ToString(0);
            txtSomaEntrada.Text = Convert.ToString(0);
            txtTotalEntrada.Text = Convert.ToString(0);
            CarregarGrid();
        }
        private bool ValidarCampos()
        {
            return true;
        }
        private void BtnDeletarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtCadastrarAmostra.Text, out id);
                    if (id > 0)
                    {
                        new DLEstoqueAmostra().Excluir(new EstoqueAmostra { EstoqueId = id });
                        MessageBox.Show("Material excluída com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtCadastrarAmostra.Text = Convert.ToString(null);
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
        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
            BloquearBotao(true);
        }
        private void BtnGerarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var estoque = new EstoqueAmostra();
                var id = new DLEstoqueAmostra().Inserir(estoque);//inserir
                txtCadastrarAmostra.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BloquearBotao(bool bloquear)
        {
            btnGerarIdAmostra.Enabled = bloquear;
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    itensamostraid = Convert.ToInt32(txtCodigoSaidaAmostra.Text);
                    material = txtAmostraSaida.Text;
                    quantidade = Convert.ToDecimal(txtSaida.Text);
                    int id = 0;
                    int.TryParse(txtCadastrarAmostra.Text, out id);
                    if (id > 0)
                    {
                        var amostraAt = new DLEstoqueAmostra().ConsultarPorId(id);
                        amostraAt.Total = Convert.ToDecimal(txtTotalSaida.Text);
                        new DLEstoqueAmostra().Atualizar(amostraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                    }
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimparMaterial_Click(object sender, EventArgs e)
        {
            LimparSaida();
        }
        private void LimparSaida()
        {
            txtCodigoSaidaAmostra.Text = Convert.ToString(null);
            txtAmostraSaida.Text = Convert.ToString("Amostra");
            txtSaida.Text = Convert.ToString(0);
            txtCalcularSaida.Text = Convert.ToString(0);
            txtTotalSaida.Text = Convert.ToString(0);
            txtPesquisar.Text = Convert.ToString("Digite para Pesquisa:");
            CarregarGrid();
        }
        private void TxtPesquisaMaterial_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void TxtPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
            MontarGrid(DgvEstoqueAmostra);
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var amostras = DgvEstoqueAmostra.Rows[e.RowIndex].DataBoundItem as EstoqueAmostra;
                if (amostras != null)
                {
                    #region Cadastro de Amostra
                    txtCadastrarAmostra.Text = amostras.EstoqueId.ToString();
                    txtAmostra.Text = amostras.Amostra;
                    txtSomaEntrada.Text = Convert.ToString(amostras.Entrada);
                    #endregion
                    #region Saida de Amostra
                    txtCodigoSaidaAmostra.Text = amostras.EstoqueId.ToString();
                    txtAmostraSaida.Text = amostras.Amostra;
                    txtCalcularSaida.Text = Convert.ToString(amostras.Entrada);
                    #endregion
                }
                HabilitarCampos(true);
                CarregarGrid();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            CalculoSaidaEstoque();
        }
        private void CalculoSaidaEstoque()
        {
            try
            {
                decimal qtdsaida = 0, saida = 0, total = 0;
                if (decimal.TryParse(txtSaida.Text, out qtdsaida))
                {
                    if (decimal.TryParse(txtCalcularSaida.Text, out saida))
                    {
                        total = saida - qtdsaida;
                    }
                    txtTotalSaida.Text = total.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {
            CalculoEntradaEstoque();
        }
        private void TxtSomaEntrada_TextChanged(object sender, EventArgs e)
        {
            CalculoEntradaEstoque();
        }
        private void CalculoEntradaEstoque()
        {
            try
            {
                decimal entrada = 0, total = 0, atualizarEstoque = 0;
                if (decimal.TryParse(txtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(txtSomaEntrada.Text, out total))
                    {
                        atualizarEstoque = entrada + total;
                    }
                    txtTotalEntrada.Text = atualizarEstoque.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void TxtSaida_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
        }
        private void TxtSaida_TextChanged_1(object sender, EventArgs e)
        {
            CalculoSaidaEstoque();
        }
    }
}
