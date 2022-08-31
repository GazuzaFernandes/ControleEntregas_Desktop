
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
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
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Click += new System.EventHandler(this.TxtSenha_Click_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = null;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Image = null;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
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
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnDeletar);
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
        private Retaguarda.iTalk.iTalk_Button_2 btnDeletar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtFabrica;
        private Retaguarda.iTalk.iTalk_Button_2 btnEntrar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSenha;
    }
}