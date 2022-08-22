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
            TabPageCadastro.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
            BloquearBotao(false);
            Carregargrid();
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLCadastrarMadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtMadeira.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.pisomadeira.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCadastroMadeira.DataSource = listarMadeira.OrderBy(p => p.madeiraid).ToList();
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
                TxtCodigoId.Text = madeira.madeiraid.ToString();
                TxtMadeira.Text = madeira.pisomadeira.ToString();
                TxtQtd.Text = madeira.m2caixa.ToString();              
                HabilitarBotao(true);
                Carregargrid();
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
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "madeiraid", "pisomadeira", "m2caixa" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "id", "PISO", "UND. MEDIDA" });
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
            BtnInserir.Enabled = desabilitar;
        }
        private void LimparCampos()
        {
            TxtMadeira.Text = Convert.ToString(null);
            TxtQtd.Text = Convert.ToString(1);
            TxtCodigoId.Text = Convert.ToString(null);           
            Carregargrid();
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void HabilitarBotao(bool habilitar)
        {
            BtnInserir.Enabled = habilitar;
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            madeiraid = Convert.ToInt32(TxtCodigoId.Text);
            material = TxtMadeira.Text;
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
                        var itenAtualizar = new DLCadastrarMadeira().ConsultarPorId(id);
                        itenAtualizar.madeiraid = Convert.ToInt32(TxtCodigoId.Text);
                        itenAtualizar.pisomadeira = TxtMadeira.Text;
                        itenAtualizar.m2caixa = Convert.ToDecimal(TxtQtd.Text);
                        new DLCadastrarMadeira().Atualizar(itenAtualizar);
                        MessageBox.Show("Piso atualizado com Sucesso ");                   
                    }
                    else
                    {
                        var itenBranco = new CadastrarMadeira();
                        itenBranco.pisomadeira = TxtMadeira.Text;
                        itenBranco.m2caixa = Convert.ToDecimal(TxtQtd.Text);
                        var idcarreto = new DLCadastrarMadeira().Inserir(itenBranco);
                        MessageBox.Show(" Material " + idcarreto + " Criado com Sucesso ");
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
                        if (listaUsuarios[i].Senha == login.TxtSenha.Text)
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
                            new DLCadastrarMadeira().Excluir(new CadastrarMadeira { madeiraid = id });
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
            Carregargrid(true);
        }
    }
}
