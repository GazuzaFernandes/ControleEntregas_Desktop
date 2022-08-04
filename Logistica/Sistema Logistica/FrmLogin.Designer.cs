
namespace LogisticaEntregas
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
            this.TxtFabrica = new Retaguarda.iTalk.iTalk_TextBox_Small();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // TxtSenha
            // 
            resources.ApplyResources(this.TxtSenha, "TxtSenha");
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.UseSystemPasswordChar = true;
            this.TxtSenha.Click += new System.EventHandler(this.TxtSenha_Click_1);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnEntrar, "BtnEntrar");
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Image = null;
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnDeletar, "BtnDeletar");
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = null;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // TxtFabrica
            // 
            this.TxtFabrica.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TxtFabrica, "TxtFabrica");
            this.TxtFabrica.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFabrica.MaxLength = 32767;
            this.TxtFabrica.Multiline = false;
            this.TxtFabrica.Name = "TxtFabrica";
            this.TxtFabrica.ReadOnly = false;
            this.TxtFabrica.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFabrica.UseSystemPasswordChar = false;
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.TxtFabrica);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Retaguarda.iTalk.iTalk_Button_2 BtnDeletar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtFabrica;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEntrar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtSenha;
    }
}