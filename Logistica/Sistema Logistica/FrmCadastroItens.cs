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
        public string material;
        public string comprimento;
        public string qtdcaixa;
        public FrmCadastroItens()
        {
            InitializeComponent();
        }
        private void FrmCadastroItens_Load(object sender, EventArgs e)
        {
            try
            {
                TabPageCadastro.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
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
                var listarmadeira = new DLcadastrarmadeira().Listar();            
                DgvCadastroMadeira.DataSource = listarmadeira.OrderBy(p => p.madeiraid).ToList();
                MontarGrid(DgvCadastroMadeira);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastroMadeira)
        {
            try
            {
                DgvCadastroMadeira.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCadastroMadeira);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "madeiraid", "pisomadeira", "comprimentos", "m2caixa" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "id", "PISO", "COMPRIMENTOS", "UND. MEDIDA" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 50, 30, 8, }, DgvCadastroMadeira.Width - 15); //O total tem que ficar em 100% 
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
        private void LimparCampos()
        {
            TxtMadeira.Text = Convert.ToString(null);
            TxtObs.Text = Convert.ToString(null);
            TxtQtd.Text = Convert.ToString(1);
            TxtCodigoId.Text = Convert.ToString(null);
          
            Carregargrid(true);
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void habilitarbotao(bool habilitar)
        {
            BtnInserir.Enabled = habilitar;
        }    
        private void DgvCadastroMadeira_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigoId.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[0].Value);
                TxtMadeira.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[1].Value);
                TxtObs.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[2].Value);
                TxtQtd.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[3].Value);
                habilitarbotao(true);
                Carregargrid();
            }
            catch (Exception ex)
            {
            MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            madeiraid = Convert.ToInt32(TxtCodigoId.Text);
            material = TxtMadeira.Text;
            comprimento = TxtObs.Text;
            qtdcaixa = TxtQtd.Text;
            Hide();

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
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
                        var cadastraratualizar = new DLcadastrarmadeira().ConsultarPorId(id);

                        cadastraratualizar.madeiraid = Convert.ToInt32(TxtCodigoId.Text);
                        cadastraratualizar.pisomadeira = TxtMadeira.Text;
                        cadastraratualizar.comprimentos = TxtObs.Text;
                        cadastraratualizar.m2caixa = Convert.ToDecimal(TxtQtd.Text);
                        new DLcadastrarmadeira().Atualizar(cadastraratualizar);
                        MessageBox.Show("Piso atualizado com Sucesso ");
                        LimparCampos();
                        Carregargrid();
                    }
                    else
                    {
                        var cadastrobranco = new cadastrarmadeira();
                        cadastrobranco.pisomadeira = TxtMadeira.Text;
                        cadastrobranco.comprimentos = TxtObs.Text;
                        cadastrobranco.m2caixa = Convert.ToDecimal(TxtQtd.Text);
                        var idcarreto = new DLcadastrarmadeira().Inserir(cadastrobranco);
                        MessageBox.Show(" Material " + idcarreto + " Criado com Sucesso ");
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
                            new DLcadastrarmadeira().Excluir(new cadastrarmadeira { madeiraid = id });
                            MessageBox.Show("Item excluído com sucesso!");
                            Carregargrid();
                            TxtCodigoId.Text = Convert.ToString(null);
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
            try
            {
                var listarmadeira = new DLcadastrarmadeira().Listar();
                var pesquisa = TxtMadeira.Text.ToLower();
                listarmadeira = listarmadeira.Where(p => p.pisomadeira.ToLower().Contains(pesquisa)).ToList();
                DgvCadastroMadeira.DataSource = listarmadeira.OrderBy(p => p.madeiraid).ToList();
                MontarGrid(DgvCadastroMadeira);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
