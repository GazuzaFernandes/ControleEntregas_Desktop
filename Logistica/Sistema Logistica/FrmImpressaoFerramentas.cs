using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmImpressaoFerramentas : Form
    {
        public FrmImpressaoFerramentas(DateTime dataretirada, string funcionario, string material)
        {
            try
            {
                InitializeComponent();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "Logistica.Ferramentas.rdlc";
                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[3];
                p[0] = new Microsoft.Reporting.WinForms.ReportParameter("dataretirada", dataretirada.ToString());
                p[1] = new Microsoft.Reporting.WinForms.ReportParameter("funcionario", funcionario);
                p[2] = new Microsoft.Reporting.WinForms.ReportParameter("material", material);
                reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmImpressaoFerramentas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
