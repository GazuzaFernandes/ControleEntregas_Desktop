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
            try
            {
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
                var listarcarr = new DLclientes().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked) listarcarr = listarcarr.Where(p => p.nome.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCliente.DataSource = listarcarr.OrderBy(p => p.nome).ToList(); 
                MontarGrid(DgvCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCliente)
        {
            try
            {
                DgvCliente.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCliente);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "nome",});
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
        private void Limparcampos()
        {
            TxtId.Text = Convert.ToString(null);
            TxtCliente.Text = Convert.ToString(null);          
        }
        private bool Validarcampos()
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
                    idcliente = Convert.ToInt32(TxtId.Text);
                    nome = TxtCliente.Text;                  
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
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtId.Text, out id);
                    if (id > 0)
                    {
                        var cadastraratualizar = new DLclientes().ConsultarPorId(id);
                        cadastraratualizar.idcliente = Convert.ToInt32(TxtId.Text);
                        cadastraratualizar.nome = TxtCliente.Text;                       
                        new DLclientes().Atualizar(cadastraratualizar);
                        MessageBox.Show("Cliente atualizado com Sucesso ");
                        Limparcampos();
                        Carregargrid();
                    }
                    else
                    {
                        var cadastrobranco = new clientes();
                        cadastrobranco.nome = TxtCliente.Text;                       
                        var idcarreto = new DLclientes().Inserir(cadastrobranco);
                        MessageBox.Show(" Cliente " + idcarreto + " Criado com Sucesso");
                        Limparcampos();
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
                var pergunta = "Deseja Realmente Deletar esse Cliente ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtId.Text, out id);
                    if (id > 0)
                    {
                        new DLclientes().Excluir(new clientes { idcliente = id });
                        MessageBox.Show("Empresa excluída com sucesso!");
                        Carregargrid();
                        TxtId.Text = Convert.ToString(null);
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
            Limparcampos();
        }
        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = Convert.ToString(DgvCliente.Rows[e.RowIndex].Cells[0].Value);
                TxtCliente.Text = Convert.ToString(DgvCliente.Rows[e.RowIndex].Cells[1].Value);              
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void TxtPesquisar_Click_1(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Carregargrid(true);
                MontarGrid(DgvCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
