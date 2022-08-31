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
    public partial class FrmNotaFical : Form
    {
        public FrmNotaFical()
        {
            InitializeComponent();
        }
        private void FrmNotaFical_Load(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
            TabCarta.BackColor = Color.FromArgb(0, 64, 0);
            TabCance.BackColor = Color.FromArgb(0, 64, 0);
            TabCodigo.BackColor = Color.FromArgb(0, 64, 0);
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtCodigoId.Text, out id);
                    if (id > 0)
                    {
                        var regraAtualizar = new DLRegraMaterial().ConsultarPorId(id);

                        regraAtualizar.Material = txtMaterial.Text;
                        regraAtualizar.Codigo = txtCodigo.Text;
                        regraAtualizar.Tributos = txtTributos.Text;
                        regraAtualizar.Ncm = txtNCM.Text;
                        regraAtualizar.CstSaida = txtCts.Text;
                        regraAtualizar.CfopSaidaSp = txtCfopSp.Text;
                        regraAtualizar.CfopSaidaoutrosufPj = txtCfopPF.Text;
                        regraAtualizar.CfopSaidaoutrosufPf = txtCfopPF.Text;
                        new DLRegraMaterial().Atualizar(regraAtualizar);
                        MessageBox.Show("Codigo atualizado com Sucesso ");                       
                    }
                    else
                    {
                        var regraBranco = new RegraMaterial();
                        regraBranco.Material = txtMaterial.Text;
                        regraBranco.Codigo = txtCodigo.Text;
                        regraBranco.Tributos = txtTributos.Text;
                        regraBranco.Ncm = txtNCM.Text;
                        regraBranco.CstSaida = txtCts.Text;
                        regraBranco.CfopSaidaSp = txtCfopSp.Text;
                        regraBranco.CfopSaidaoutrosufPj = txtCfopPF.Text;
                        regraBranco.CfopSaidaoutrosufPf = txtCfopPF.Text;
                        var idNotaFiscal = new DLRegraMaterial().Inserir(regraBranco);
                        MessageBox.Show(" Codigo " + idNotaFiscal + " Criado com Sucesso");                       
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
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            txtMaterial.Text = Convert.ToString(null);
            txtCodigo.Text = Convert.ToString(null);
            txtTributos.Text = Convert.ToString(null);
            txtNCM.Text = Convert.ToString(null);
            txtCts.Text = Convert.ToString(null);
            txtCfopSp.Text = Convert.ToString(null);
            txtCfopPF.Text = Convert.ToString(null);
            txtCfopPF.Text = Convert.ToString(null);
            txtCodigoId.Text = Convert.ToString(null);
            RbCodigo.Checked = false;
            RbMaterial.Checked = false;
            TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
        }
        private void BtnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Carregargrid();
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtCodigoId.Text, out id);
                if (id > 0)
                {
                    new DLRegraMaterial().Excluir(new RegraMaterial { RegrasId = id });
                    MessageBox.Show("Codigo excluída com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("id Invalido");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtPesquisar_Click_1(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvCogidos);
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarregra = new DLRegraMaterial().Listar();
                if (isPesquisa)
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbMaterial.Checked)
                        listarregra = listarregra.Where(p => p.Material.ToLower().Contains(pesquisa)).ToList();
                    else if (RbCodigo.Checked)
                        listarregra = listarregra.Where(p => p.Codigo.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCogidos.DataSource = listarregra;
                MontarGrid(DgvCogidos);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCogidos)
        {
            try
            {
                DgvCogidos.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCogidos);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "Codigo", "Tributos", "Ncm", "Cstsaida", "Cfopsaidasp", "CfopSaidaOutrosufPj", "CfopSaidaOutrosufPf", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "MATERIAL", "CODIGO", "% TRIBUTOS", "NCM", "CST / SAIDA", "CFOP SAIDA - SP", "CFOP SAIDA OUTROS UF PJ", "CFOP SAÍDA OUTROS UF PF", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 10, 8, 10, 8, 13, 14, 17, }, DgvCogidos.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvCogidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var regrasMateriais = DgvCogidos.Rows[e.RowIndex].DataBoundItem as RegraMaterial;
                if(regrasMateriais != null)
                {
                    txtCodigoId.Text = regrasMateriais.RegrasId.ToString();
                    txtMaterial.Text = regrasMateriais.Material;
                    txtCodigo.Text = regrasMateriais.Codigo;
                    txtTributos.Text = regrasMateriais.Tributos;
                    txtNCM.Text = regrasMateriais.Ncm;
                    txtCts.Text = regrasMateriais.CstSaida;
                    txtCfopSp.Text = regrasMateriais.CfopSaidaSp;
                    txtCfopPF.Text = regrasMateriais.CfopSaidaoutrosufPf;
                    txtCfopPF.Text = regrasMateriais.CfopSaidaoutrosufPj;

                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
