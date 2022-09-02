using DALLogistica.Entities;
using DALLogistica.Repository;
using DALSenhas.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmCadastroItens : Form
    {
        public int madeiraid;
        public string material, comprimento, qtdcaixa;       
        internal CadastrarMadeira _cadastro;
        public FrmCadastroItens()
        {
            InitializeComponent();
        }
        private void FrmCadastroItens_Load(object sender, EventArgs e)
        {
            tabPageCadastro.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
            BloquearBotao(false);
            CarregarGrid();
        }
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLCadastrarMadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtMadeira.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.PisoMadeira.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCadastroMadeira.DataSource = listarMadeira.OrderBy(p => p.MadeiraId).ToList();
                MontarGrid(DgvCadastroMadeira);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvCadastroMadeira_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // O DataBoundItem eu utilizei pelo fato de utilizar o TxtMadeira para realizar a pesquisa assim excluindo o 
                // campo TxtPesquisar.
                var madeira = DgvCadastroMadeira.Rows[e.RowIndex].DataBoundItem as CadastrarMadeira;
                if(madeira != null)
                {
                    txtCodigoId.Text = madeira.MadeiraId.ToString();
                    txtMadeira.Text = madeira.PisoMadeira.ToString();
                    txtQuantidade.Text = madeira.M2Caixa.ToString();
                }                          
                HabilitarBotao(true);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastroMadeira)
        {
            try
            {
                DgvCadastroMadeira.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCadastroMadeira);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "MadeiraId", "PisoMadeira", "M2Caixa" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "CODIGO", "PISO", "UND. MEDIDA" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 80, 8, }, DgvCadastroMadeira.Width - 15); //O total tem que ficar em 100% 
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
        private void LimparCampos()
        {
            txtMadeira.Text = Convert.ToString(null);
            txtQuantidade.Text = Convert.ToString(1);
            txtCodigoId.Text = Convert.ToString(null);           
            CarregarGrid();
        }
        private bool ValidarCampos()
        {
            return true;
        }
        private void HabilitarBotao(bool habilitar)
        {
            btnInserir.Enabled = habilitar;
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            madeiraid = Convert.ToInt32(txtCodigoId.Text);
            material = txtMadeira.Text;
            qtdcaixa = txtQuantidade.Text;            
            Hide();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
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
                        var itenAtualizar = new DLCadastrarMadeira().ConsultarPorId(id);
                        itenAtualizar.MadeiraId = Convert.ToInt32(txtCodigoId.Text);
                        itenAtualizar.PisoMadeira = txtMadeira.Text;
                        itenAtualizar.M2Caixa = Convert.ToDecimal(txtQuantidade.Text);
                        new DLCadastrarMadeira().Atualizar(itenAtualizar);
                        MessageBox.Show("Piso atualizado com Sucesso ");                   
                    }
                    else
                    {
                        var itenBranco = new CadastrarMadeira();
                        itenBranco.PisoMadeira = txtMadeira.Text;
                        itenBranco.M2Caixa = Convert.ToDecimal(txtQuantidade.Text);
                        var idItens = new DLCadastrarMadeira().Inserir(itenBranco);
                        MessageBox.Show(" Material " + idItens + " Criado com Sucesso ");
                    }
                    LimparCampos();
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir esse Item ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLUsuario().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senha == login.txtSenha.Text)
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
                            new DLCadastrarMadeira().Excluir(new CadastrarMadeira { MadeiraId = id });
                            MessageBox.Show("Item excluído com sucesso!");
                            CarregarGrid();
                            txtCodigoId.Text = Convert.ToString(null);
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
        private void TxtMadeira_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
        }
    }
}
