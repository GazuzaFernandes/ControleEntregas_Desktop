using DALSenhas.Repository;
using Logistica.Sistema_Controle_de_Preços;
using Logistica.Sistema_de_Amostras;
using Logistica.Sistema_Financeiro_Estoque;
using LogisticaEntregas;

using System;
using System.Windows.Forms;
using static Logistica.BackupAutomatico;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Logistica
{
    public partial class FrmEscolherSistema : Form
    {
        public FrmEscolherSistema()
        {
            InitializeComponent();
        }
        private void BtnEstoqueF_Click(object sender, EventArgs e)
        {
            FrmPrincipalFinanceiro financeiro = new FrmPrincipalFinanceiro();
            financeiro.Show();
        }
        private void BtnLogistica_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();          
        }
        private void BtnValores_Click(object sender, EventArgs e)
        {
            FrmPrincpalValores valores = new FrmPrincpalValores();
            valores.Show();           
        }
        private void FrmEscolherSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BtnAmostra_Click(object sender, EventArgs e)
        {
            FrmPrincipalAmostra amostra = new FrmPrincipalAmostra();
            amostra.Show();            
        }
        private void FrmEscolherSistema_Load(object sender, EventArgs e)
        {

        }

    }
}
