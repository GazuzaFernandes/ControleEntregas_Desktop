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
                    int.TryParse(TxtCodigoId.Text, out id);
                    if (id > 0)
                    {
                        var regraAtualizar = new DLRegraMaterial().ConsultarPorId(id);

                        regraAtualizar.material = TxtMaterial.Text;
                        regraAtualizar.codigo = TxtCodigo.Text;
                        regraAtualizar.tributos = TxtTributos.Text;
                        regraAtualizar.ncm = TxtNCM.Text;
                        regraAtualizar.cstsaida = TxtCts.Text;
                        regraAtualizar.cfopsaidasp = TxtCfopSp.Text;
                        regraAtualizar.cfopsaidaoutrosufpj = TxtCfopPF.Text;
                        regraAtualizar.cfopsaidaoutrosufpf = TxtCfopPF.Text;
                        new DLRegraMaterial().Atualizar(regraAtualizar);
                        MessageBox.Show("Codigo atualizado com Sucesso ");                       
                    }
                    else
                    {
                        var regraBranco = new RegraMaterial();
                        regraBranco.material = TxtMaterial.Text;
                        regraBranco.codigo = TxtCodigo.Text;
                        regraBranco.tributos = TxtTributos.Text;
                        regraBranco.ncm = TxtNCM.Text;
                        regraBranco.cstsaida = TxtCts.Text;
                        regraBranco.cfopsaidasp = TxtCfopSp.Text;
                        regraBranco.cfopsaidaoutrosufpj = TxtCfopPF.Text;
                        regraBranco.cfopsaidaoutrosufpf = TxtCfopPF.Text;
                        var idcarreto = new DLRegraMaterial().Inserir(regraBranco);
                        MessageBox.Show(" Codigo " + idcarreto + "Criado com Sucesso");                       
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
            TxtMaterial.Text = Convert.ToString(null);
            TxtCodigo.Text = Convert.ToString(null);
            TxtTributos.Text = Convert.ToString(null);
            TxtNCM.Text = Convert.ToString(null);
            TxtCts.Text = Convert.ToString(null);
            TxtCfopSp.Text = Convert.ToString(null);
            TxtCfopPF.Text = Convert.ToString(null);
            TxtCfopPF.Text = Convert.ToString(null);
            TxtCodigoId.Text = Convert.ToString(null);
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
                int.TryParse(TxtCodigoId.Text, out id);
                if (id > 0)
                {
                    new DLRegraMaterial().Excluir(new RegraMaterial { regrasid = id });
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
                        listarregra = listarregra.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                    else if (RbCodigo.Checked)
                        listarregra = listarregra.Where(p => p.codigo.ToLower().Contains(pesquisa)).ToList();
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
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "material", "codigo", "tributos", "ncm", "cstsaida", "cfopsaidasp", "cfopsaidaoutrosufpj", "cfopsaidaoutrosufpf", });
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
                TxtCodigoId.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[0].Value);
                TxtMaterial.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[1].Value);
                TxtCodigo.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[2].Value);
                TxtTributos.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[3].Value);
                TxtNCM.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[4].Value);
                TxtCts.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[5].Value);
                TxtCfopSp.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[6].Value);
                TxtCfopPF.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[7].Value);
                TxtCfopPF.Text = Convert.ToString(DgvCogidos.Rows[e.RowIndex].Cells[8].Value);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
