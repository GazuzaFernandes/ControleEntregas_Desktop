using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }
        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            Carregargrid();
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvMaterial);
        }
        private void DgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               var infoMaterial = DgvMaterial.Rows[e.RowIndex].DataBoundItem as InfoMaterial;
                if(infoMaterial != null)
                {
                    txtMaterialId.Text = infoMaterial.MaterialId.ToString();
                    txtMaterial.Text = infoMaterial.Material;
                    rtbMaterial.Text = infoMaterial.Utilidade;
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtMaterialId.Text, out id);
                    if (id > 0)
                    {
                        var materialAtualizar = new DLInfoMaterial().ConsultarPorId(id);
                        materialAtualizar.Material = txtMaterial.Text;
                        materialAtualizar.Utilidade = rtbMaterial.Text;
                        new DLInfoMaterial().Atualizar(materialAtualizar);
                        MessageBox.Show("Material atualizado com Sucesso ");                       
                    }
                    else
                    {
                        var materialBranco = new InfoMaterial();
                        materialBranco.Material = txtMaterial.Text;
                        materialBranco.Utilidade = rtbMaterial.Text;
                        var idMaterial = new DLInfoMaterial().Inserir(materialBranco);
                        MessageBox.Show(" Material " + idMaterial + " Criado com Sucesso");                        
                    }
                    LimparCampos();
                    Carregargrid();
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
                var pergunta = "Deseja realmente deletar o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtMaterialId.Text, out id);
                    if (id > 0)
                    {
                        new DLInfoMaterial().Excluir(new InfoMaterial { MaterialId = id });
                        MessageBox.Show("Material excluído com sucesso!");
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

        #region Campo de Metodos 
        private void LimparCampos()
        {
            txtMaterialId.Text = Convert.ToString(null);
            txtMaterial.Text = Convert.ToString(null);
            txtPesquisar.Text = Convert.ToString("Selecione Material ou Utilizado para pesquisar");
            rtbMaterial.Text = Convert.ToString(null);
            rbutilizado.Checked = false;
            rbMaterial.Checked = false;
        }
        private bool ValidarCampos()
        {
            return true;
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarMaterial = new DLInfoMaterial().Listar();
                if (isPesquisa)
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbMaterial.Checked)
                        listarMaterial = listarMaterial.Where(p => p.Material.ToLower().Contains(pesquisa)).ToList();
                    else if (rbutilizado.Checked)
                        listarMaterial = listarMaterial.Where(p => p.Utilidade.ToLower().Contains(pesquisa)).ToList();
                }
                DgvMaterial.DataSource = listarMaterial;
                MontarGrid(DgvMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvMaterial)
        {
            try
            {
                DgvMaterial.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "Utilidade" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Para que é Usado" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 45, 54 }, DgvMaterial.Width - 15); //O total tem que ficar em 100% 
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
        #endregion
    }
}
