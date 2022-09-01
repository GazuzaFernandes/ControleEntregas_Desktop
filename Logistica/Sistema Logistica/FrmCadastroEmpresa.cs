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
            BloquearBotao(false);
            CarregarGrid();
        }
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var listarEmpresa = new DLCadastrarEmpresa().Listar();
                var pesquisa = txtEmpresaCliente.Text.ToLower();
                listarEmpresa = listarEmpresa.Where(p => p.Empresa.ToLower().Contains(pesquisa)).ToList();
                DgvCadastroEmpresa.DataSource = listarEmpresa.OrderBy(p => p.EmpresaId).ToList();
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
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "EmpresaId", "Empresa", });
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
        private void BloquearBotao(bool desabilitar)
        {
            btnInserir.Enabled = desabilitar;
        }
        private bool ValidarCampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            txtCodigoId.Text = Convert.ToString(null);
            txtEmpresaCliente.Text = Convert.ToString(null);           
            CarregarGrid();
        }
        private void DgvCadastroEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cadastroEmpresa = DgvCadastroEmpresa.Rows[e.RowIndex].DataBoundItem as CadastrarEmpresa;
                if( cadastroEmpresa != null)
                {
                    txtCodigoId.Text = cadastroEmpresa.EmpresaId.ToString();
                    txtEmpresaCliente.Text = cadastroEmpresa.Empresa;
                }                
                HabilitarBotao(true);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void HabilitarBotao(bool habilitar)
        {
            btnInserir.Enabled = habilitar;
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            empresaid = Convert.ToInt32(txtCodigoId.Text);
            empresa = txtEmpresaCliente.Text;
            Hide();
        }
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtCodigoId.Text, out id);
                    if (id > 0)
                    {
                        var clieAtualizar = new DLCadastrarEmpresa().ConsultarPorId(id);
                        clieAtualizar.EmpresaId = Convert.ToInt32(txtCodigoId.Text);
                        clieAtualizar.Empresa = txtEmpresaCliente.Text;
                        new DLCadastrarEmpresa().Atualizar(clieAtualizar);
                        MessageBox.Show("Empresa/Cliente atualizado com Sucesso ");                        
                    }
                    else
                    {
                        var clientBranco = new CadastrarEmpresa();
                        clientBranco.Empresa = txtEmpresaCliente.Text;
                        var idempresa = new DLCadastrarEmpresa().Inserir(clientBranco);
                        MessageBox.Show(" Empresa/Cliente " + idempresa + " Criado com Sucesso");                        
                    }
                }
                LimparCampos();
                CarregarGrid();
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
                var pergunta = "Deseja Realmente excluir esse Cadastro ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLSenha().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senhas == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(txtCodigoId.Text, out id);
                        if (id > 0)
                        {
                            new DLCadastrarEmpresa().Excluir(new CadastrarEmpresa { EmpresaId = id });
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
                CarregarGrid(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
