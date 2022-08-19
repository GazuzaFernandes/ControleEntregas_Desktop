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
        public FrmEstoqueAmostra()
        {
            InitializeComponent();
        }
        private void FrmEstoqueAmostra_Load(object sender, EventArgs e)
        {
            try
            {
                Carregargrid();
                HabilitarCampos(false);             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }     
        private void HabilitarCampos(bool habilitar)
        {
            TxtAmostra.Enabled = habilitar;
            TxtEntrada.Enabled = habilitar;          
            BtnSalvarMaterial.Enabled = habilitar;
            BtnDeletarMaterial.Enabled = habilitar;
            BtnLimparTudo.Enabled = habilitar;
            TxtSaida.Enabled = habilitar;
            BtnSelecionar.Enabled = habilitar;
            BtnLimparMaterial.Enabled = habilitar;            
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarmadeira = new DLEstoqueAmostra().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower(); if (RbPesquisar.Checked)
                        listarmadeira = listarmadeira.Where(p => p.amostra.ToLower().Contains(pesquisa)).ToList();
                }
                DgvEstoqueAmostra.DataSource = listarmadeira.OrderBy(p => p.total).ToList(); 
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
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "amostra", "total", });
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
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtEstoqueId.Text, out id);
                    if (id > 0)
                    {
                        var EstoqueAt = new DLEstoqueAmostra().ConsultarPorId(id);
                        EstoqueAt.estoqueid = Convert.ToInt32(TxtEstoqueId.Text);
                        EstoqueAt.amostra = TxtAmostra.Text;                      
                        EstoqueAt.entrada = Convert.ToDecimal(TxtEntrada.Text);
                        EstoqueAt.total = Convert.ToDecimal(TxtTotalEntrada.Text);
                        new DLEstoqueAmostra().Atualizar(EstoqueAt);
                        MessageBox.Show("Estoque atualizado com Sucesso ");
                        Limparcampos();
                        Carregargrid();
                        HabilitarCampos(false);
                        bloquearbotao(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Limparcampos()
        {
            TxtEstoqueId.Text = Convert.ToString(null);
            TxtAmostra.Text = Convert.ToString(null);
            TxtEntrada.Text = Convert.ToString(0);
            TxtSomaEntrada.Text = Convert.ToString(0);
            TxtTotalEntrada.Text = Convert.ToString(0);
            Carregargrid();
        }
        private bool Validarcampos()
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
                    int.TryParse(TxtEstoqueId.Text, out id);
                    if (id > 0)
                    {
                        new DLEstoqueAmostra().Excluir(new EstoqueAmostra { estoqueid = id });
                        MessageBox.Show("Material excluída com sucesso!");
                        Carregargrid();
                        Limparcampos();
                        TxtEstoqueId.Text = Convert.ToString(null);
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
            Limparcampos();
            HabilitarCampos(false);
            bloquearbotao(true);
        }
        private void BtnGerarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var estoque = new EstoqueAmostra();
                var id = new DLEstoqueAmostra().Inserir(estoque);//inserir
                TxtEstoqueId.Text = id.ToString();
                bloquearbotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void bloquearbotao(bool bloquear)
        {
            BtnGerarMaterial.Enabled = bloquear;
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    itensamostraid = Convert.ToInt32(TxtcodigoMaterial.Text);                   
                    material = TxtAmostraSaida.Text;
                    quantidade = Convert.ToDecimal(TxtSaida.Text);
                    int id = 0;
                    int.TryParse(TxtEstoqueId.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLEstoqueAmostra().ConsultarPorId(id);
                        madeiraAt.total = Convert.ToDecimal(TxtTotalSaida.Text);
                        new DLEstoqueAmostra().Atualizar(madeiraAt);
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
            TxtcodigoMaterial.Text = Convert.ToString(null);
            TxtAmostraSaida.Text = Convert.ToString("Amostra");
            TxtSaida.Text = Convert.ToString(0);
            TxtSaida2.Text = Convert.ToString(0);
            TxtTotalSaida.Text = Convert.ToString(0);
            TxtPesquisar.Text = Convert.ToString("Digite para Pesquisa:" );
            Carregargrid();

        }
        private void TxtPesquisaMaterial_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvEstoqueAmostra);
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   // Cadastro de Amostra
                TxtEstoqueId.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[0].Value);
                TxtAmostra.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[1].Value);
                TxtSomaEntrada.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[3].Value);
                // Saida de Amostra
                TxtcodigoMaterial.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[0].Value);
                TxtAmostraSaida.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[1].Value);
                TxtSaida2.Text = Convert.ToString(DgvEstoqueAmostra.Rows[e.RowIndex].Cells[3].Value);
                HabilitarCampos(true);
                Carregargrid();
                bloquearbotao(false);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }      
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            RetiradaEstoque();
        }
        private void RetiradaEstoque()
        {
            try
            {
                decimal qtdsaida = 0;
                decimal saida = 0;
                decimal total = 0;
                if (decimal.TryParse(TxtSaida.Text, out qtdsaida))
                {
                    if (decimal.TryParse(TxtSaida2.Text, out saida))
                    {
                        total = saida - qtdsaida;
                    }
                    TxtTotalSaida.Text = total.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {
            SomaEntrada();
        }
        private void TxtSomaEntrada_TextChanged(object sender, EventArgs e)
        {
            SomaEntrada();
        }
        private void SomaEntrada()
        {
            try
            {
                decimal entrada = 0;
                decimal total = 0;
                decimal total2 = 0;
                if (decimal.TryParse(TxtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(TxtSomaEntrada.Text, out total))
                    {
                        total2 = entrada + total;
                    }
                    TxtTotalEntrada.Text = total2.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtSaida_Click(object sender, EventArgs e)
        {
            TxtSaida.Clear();
        }

        private void TxtSaida_TextChanged_1(object sender, EventArgs e)
        {
            RetiradaEstoque();
        }
    }
}
