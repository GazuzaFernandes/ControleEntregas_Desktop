using DALLogistica.Entities;
using DALLogistica.Repository;
using DALSenhas.Repository;
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
    public partial class FrmCadastroEmpresa : Form
    {
        public int empresaid;
        public string empresa;
        public string construtora;
        public FrmCadastroEmpresa()
        {
            InitializeComponent();
        }
        private void FrmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                bloquearbotao(false);
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarEmpresa = new DLcadastrarempresa().Listar();
                DgvCadastroEmpresa.DataSource = listarEmpresa.OrderBy(p => p.empresaid).ToList();
                MontarGrid(DgvCadastroEmpresa);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastroEmpresa)
        {
            try
            {
                DgvCadastroEmpresa.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCadastroEmpresa);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "empresaid", "empresa", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "id", "Empresa, Construtora, Cliente, Fabricas", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 85, }, DgvCadastroEmpresa.Width - 25); //O total tem que ficar em 100% 
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
        private void bloquearbotao(bool desabilitar)
        {
            BtnInserir.Enabled = desabilitar;
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            TxtCodigoId.Text = Convert.ToString(null);
            TxtEmpresa.Text = Convert.ToString(null);           
            Carregargrid();

        }
        private void DgvCadastroEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigoId.Text = Convert.ToString(DgvCadastroEmpresa.Rows[e.RowIndex].Cells[0].Value);
                TxtEmpresa.Text = Convert.ToString(DgvCadastroEmpresa.Rows[e.RowIndex].Cells[1].Value);
                hablitarbotao(true);
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void hablitarbotao(bool habilitar)
        {
            BtnInserir.Enabled = habilitar;
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            empresaid = Convert.ToInt32(TxtCodigoId.Text);
            empresa = TxtEmpresa.Text;
            Hide();
        }
        private void BtnSalvar_Click_1(object sender, EventArgs e)
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
                        var cadastraratualizar = new DLcadastrarempresa().ConsultarPorId(id);
                        cadastraratualizar.empresaid = Convert.ToInt32(TxtCodigoId.Text);
                        cadastraratualizar.empresa = TxtEmpresa.Text;

                        new DLcadastrarempresa().Atualizar(cadastraratualizar);
                        MessageBox.Show("Empresa/Cliente atualizado com Sucesso ");
                        LimparCampos();
                        Carregargrid();
                    }
                    else
                    {
                        var cadastrobranco = new cadastrarempresa();
                        cadastrobranco.empresa = TxtEmpresa.Text;

                        var idcarreto = new DLcadastrarempresa().Inserir(cadastrobranco);
                        MessageBox.Show(" Empresa/Cliente " + idcarreto + "Criado com Sucesso");
                        LimparCampos();
                        Carregargrid();
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
                var pergunta = "Deseja Realmente excluir essa proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLsenha().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].senhass == login.TxtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(TxtCodigoId.Text, out id);
                        if (id > 0)
                        {
                            new DLcadastrarempresa().Excluir(new cadastrarempresa { empresaid = id });
                            MessageBox.Show("Empresa ou Cliente excluído com sucesso!");                            
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

         
            LimparCampos();
        }

        private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var listarEmpresa = new DLcadastrarempresa().Listar();

                var pesquisa = TxtEmpresa.Text.ToLower();               
                    listarEmpresa = listarEmpresa.Where(p => p.empresa.ToLower().Contains(pesquisa)).ToList();

                DgvCadastroEmpresa.DataSource = listarEmpresa.OrderBy(p => p.empresaid).ToList();
                MontarGrid(DgvCadastroEmpresa);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
