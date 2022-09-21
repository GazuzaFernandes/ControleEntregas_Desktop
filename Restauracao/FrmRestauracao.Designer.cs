
namespace Restauracao
{
    partial class FrmRestauracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestauracao));
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnRestaurar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
            this.TxtFabrica = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.TxtSenha.Location = new System.Drawing.Point(135, 124);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(195, 34);
            this.TxtSenha.TabIndex = 27;
            this.TxtSenha.Text = "111111";
            this.TxtSenha.UseSystemPasswordChar = true;
            this.TxtSenha.Click += new System.EventHandler(this.TxtSenha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(39, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Login:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(135, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 34);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Adminstrador";
            this.textBox1.Click += new System.EventHandler(this.TxtSenha_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaurar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnRestaurar.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurar.Image = null;
            this.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRestaurar.Location = new System.Drawing.Point(73, 178);
            this.BtnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(117, 44);
            this.BtnRestaurar.TabIndex = 24;
            this.BtnRestaurar.Text = "Restaurar";
            this.BtnRestaurar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = null;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(213, 178);
            this.BtnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(117, 44);
            this.BtnDeletar.TabIndex = 25;
            this.BtnDeletar.Text = "Fechar";
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // TxtFabrica
            // 
            this.TxtFabrica.BackColor = System.Drawing.Color.Transparent;
            this.TxtFabrica.Enabled = false;
            this.TxtFabrica.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtFabrica.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFabrica.Location = new System.Drawing.Point(-416, -184);
            this.TxtFabrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFabrica.MaxLength = 32767;
            this.TxtFabrica.Multiline = false;
            this.TxtFabrica.Name = "TxtFabrica";
            this.TxtFabrica.ReadOnly = false;
            this.TxtFabrica.Size = new System.Drawing.Size(259, 33);
            this.TxtFabrica.TabIndex = 23;
            this.TxtFabrica.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFabrica.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(141, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Restauração do Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restauracao.Properties.Resources.icons8_restauração_de_banco_de_dados_80;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(357, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // FrmRestauracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRestaurar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.TxtFabrica);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRestauracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauração do Sistema Rb Pisos";
            this.Load += new System.EventHandler(this.FrmRestauracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_Button_2 BtnRestaurar;
        private Retaguarda.iTalk.iTalk_Button_2 BtnDeletar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtFabrica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}