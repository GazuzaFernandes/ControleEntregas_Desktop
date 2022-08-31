using DALFinanceiro.Entities;
using DALFinanceiro.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Sistema_Financeiro_Estoque
{
    public partial class FrmClienteFinanceiro : Form
    {
        public int idcliente;
        public string nome;
        public string email;
        public FrmClienteFinanceiro()
        {
            InitializeComponent();
        }
        private void FrmClienteFinanceiro_Load(object sender, EventArgs e)
        {
            CarregarGridCliente();
        }
        private void CarregarGridCliente(bool isPesquisa = false)
        {
            try
            {
                var listarCliente = new DLClientes().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtCliente.Text.ToLower();
                  listarCliente = listarCliente.Where(p => p.Nome.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCliente.DataSource = listarCliente.OrderBy(p => p.Nome).ToList(); 
                MontarGridCliente(DgvCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridCliente(DataGridView dgvCliente)
        {
            try
            {
                DgvCliente.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCliente);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Nome",});
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cliente",});
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() {100,}, DgvCliente.Width - 15); //O total tem que ficar em 100% 
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
        private void LimparCampos()
        {
            txtClienteId.Text = Convert.ToString(null);
            txtCliente.Text = Convert.ToString(null);          
        }
        private bool ValidarCampos()
        {
            return true;
        }         
        private void BtnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Inseir o Cliente ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idcliente = Convert.ToInt32(txtClienteId.Text);
                    nome = txtCliente.Text;                  
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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
                    int.TryParse(txtClienteId.Text, out id);
                    if (id > 0)
                    {
                        var clieAtualizar = new DLClientes().ConsultarPorId(id);
                        clieAtualizar.IdCliente = Convert.ToInt32(txtClienteId.Text);
                        clieAtualizar.Nome = txtCliente.Text;                       
                        new DLClientes().Atualizar(clieAtualizar);
                        MessageBox.Show("Cliente atualizado com Sucesso ");                        
                    }
                    else
                    {
                        var clieBranco = new Clientes();
                        clieBranco.Nome = txtCliente.Text;                       
                        var idCliente = new DLClientes().Inserir(clieBranco);
                        MessageBox.Show(" Cliente " + idCliente + " Criado com Sucesso");                       
                    }
                }
                LimparCampos();
                CarregarGridCliente();
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
                var pergunta = "Deseja Realmente Deletar esse Cliente ou Empresa ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtClienteId.Text, out id);
                    if (id > 0)
                    {
                        new DLClientes().Excluir(new Clientes { IdCliente = id });
                        MessageBox.Show("Cliente ou Empresa excluída com sucesso!");
                        CarregarGridCliente();
                        txtClienteId.Text = Convert.ToString(null);
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
        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cliente = DgvCliente.Rows[e.RowIndex].DataBoundItem as Clientes;
                if(cliente != null)
                {
                    txtClienteId.Text = cliente.IdCliente.ToString();
                    txtCliente.Text = cliente.Nome;
                }                      
                CarregarGridCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            CarregarGridCliente(true);
            MontarGridCliente(DgvCliente);
        }
    }
}
