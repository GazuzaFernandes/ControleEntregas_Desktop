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
                var listaProp = new DLproposta().Listar();
                carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarpro = new DLproposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    if (RbEngenharia.Checked)
                        listarpro = listarpro.Where(p => p.Status.Equals("RbEngenharia")).ToList();
                    else if (RbComercio.Checked)
                        listarpro = listarpro.Where(p => p.Status.Equals("RbComercio")).ToList();
                    else if (RbPisos.Checked)
                        listarpro = listarpro.Where(p => p.Status.Equals("RbPisos")).ToList();

                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbObra.Checked)
                        listarpro = listarpro.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    if (RbProposta.Checked)
                        listarpro = listarpro.Where(p => p.propostas.ToLower().Contains(pesquisa)).ToList();
                    if (RbNf.Checked)
                        listarpro = listarpro.Where(p => p.notafiscal.ToLower().Contains(pesquisa)).ToList();
                }
                DgvPrincipal.DataSource = listarpro;
                montargrid(DgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void montargrid(DataGridView dgvPrincipal)
        {
            DgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "emissaonf", "vencimentonf", "cliente", "propostas", "notafiscal", "obra" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Emissão da NF", "Vencimento da NF", "Cliente", "Propostas", "Nota Fiscal", "Obra" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 15, 10, 10, 10, 40, }, DgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void BtnProposta_Click(object sender, EventArgs e)
        {
            FrmLancaNotaFiscal proposta = new FrmLancaNotaFiscal();
            proposta.ShowDialog();
            carregargrid();
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
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregargrid(true);
            montargrid(DgvPrincipal);
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            carregargrid(true);
            montargrid(DgvPrincipal);
        }
        private void BtnLimparPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar");
            RbPisos.Checked = false;
            RbObra.Checked = false;
            RbNf.Checked = false;
            RbEngenharia.Checked = false;
            carregargrid();
        }
        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new proposta();
                prop.idprop = Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                FrmLancaNotaFiscal frmproposta = new FrmLancaNotaFiscal();
                frmproposta._notafiscal = prop;
                frmproposta.ShowDialog();
                carregargrid();
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
                var valor = Convert.ToString(DgvPrincipal.Rows[i].Cells[14].Value);
                switch (valor)
                {
                    case "RbEngenharia": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "RbComercio": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "RbPisos": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }

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
                                           $@"C:\Users\logistica\source\repos\BACKUP\SistemaFinanceiro\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaFinanceiro");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
