using DALFinanceiro.Entities;
using DALFinanceiro.Repository;
using DALSenhas.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Logistica.Sistema_Financeiro_Estoque
{
    public partial class FrmPrincipalFinanceiro : Form
    {
        public FrmPrincipalFinanceiro()
        {
            InitializeComponent();
        }
        private void FrmPrincipalFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProp = new DLProposta().Listar();
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Apenas Metodos
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarFinanceiro = new DLProposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    if (rbEngenharia.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Status.Equals("RbEngenharia")).ToList();
                    else if (rbComercio.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Status.Equals("RbComercio")).ToList();
                    else if (rbPisos.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Status.Equals("RbPisos")).ToList();

                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbObra.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbProposta.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Propostas.ToLower().Contains(pesquisa)).ToList();
                    else if (rbNf.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Notafiscal.ToLower().Contains(pesquisa)).ToList();
                }
                DgvPrincipal.DataSource = listarFinanceiro;
                MontarGrid(DgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvPrincipal)
        {
            DgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "EmissaoNf", "VencimentoNf", "Cliente", "Propostas", "Notafiscal", "Obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Emissão da NF", "Vencimento da NF", "Cliente", "Propostas", "Nota Fiscal", "Obra", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 15, 10, 10, 10, 40, }, DgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion

        #region Apenas Botões
        private void BtnProposta_Click(object sender, EventArgs e)
        {
            FrmLancaNotaFiscal proposta = new FrmLancaNotaFiscal();
            proposta.ShowDialog();
            Carregargrid();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueFinanceiro madeira = new FrmEstoqueFinanceiro();
            madeira.ShowDialog();
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmClienteFinanceiro cliente = new FrmClienteFinanceiro();
            cliente.ShowDialog();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvPrincipal);
        }
        private void BtnLimparPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString("Digite para Pesquisar");
            rbPisos.Checked = false;
            rbObra.Checked = false;
            rbNf.Checked = false;
            rbEngenharia.Checked = false;
            Carregargrid();
        }
        #endregion

        #region Apenas Grids
        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new Proposta();
                prop.IdProp = Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                FrmLancaNotaFiscal propFinanceiro = new FrmLancaNotaFiscal();
                propFinanceiro._notafiscal = prop;
                propFinanceiro.ShowDialog();
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvPrincipal.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvPrincipal.Rows[i].Cells[12].Value);
                switch (valor)
                {
                    case "RbEngenharia": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "RbComercio": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "RbPisos": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }
        #endregion

        #region Apenas Text Box
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvPrincipal);
        }
        #endregion

        private void FrmPrincipalFinanceiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FunctionsDataBase.BackupDatabase(
                                             "192.168.0.202",
                                             "5432",
                                             "postgres",
                                             "q1s2e3f4t5",
                                             "FinanceiroEstoque",
                                           $@"F:\_LOGISTICA\Restauração\SistemaFinanceiro\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaFinanceiro");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
