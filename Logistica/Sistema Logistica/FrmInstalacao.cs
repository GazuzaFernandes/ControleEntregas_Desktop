using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmInstalacao : Form
    {
        public FrmInstalacao()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 10)
            {
                timer1.Start();
                timer1.Stop();
               // FindConfigurationFile();
          
            }

            if (progressBar1.Value == 35)
            {
                timer1.Start();
                timer1.Stop();
                label1.Text = "Carregando Banco de dados.....";
                // FindConfigurationFile();
              
            }


            if (progressBar1.Value == 80)
            {
                timer1.Start();
               
                label1.Text = "Abrindo Sistema...";
                // FindConfigurationFile();
                timer1.Stop();
            }

        }
    }
}
