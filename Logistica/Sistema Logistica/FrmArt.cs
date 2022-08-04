using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmArt : Form
    {
        public FrmArt()
        {
            InitializeComponent();
        }

        private void FrmArt_Load(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
        }
    }
}
