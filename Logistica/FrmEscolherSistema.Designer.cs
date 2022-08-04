
namespace Logistica
{
    partial class FrmEscolherSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscolherSistema));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogistica = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnEstoqueF = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnValores = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogistica
            // 
            this.BtnLogistica.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogistica.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLogistica.ForeColor = System.Drawing.Color.White;
            this.BtnLogistica.Image = null;
            this.BtnLogistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogistica.Location = new System.Drawing.Point(23, 132);
            this.BtnLogistica.Name = "BtnLogistica";
            this.BtnLogistica.Size = new System.Drawing.Size(215, 127);
            this.BtnLogistica.TabIndex = 4;
            this.BtnLogistica.Text = "Sistema de Entrega de Materiais";
            this.BtnLogistica.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLogistica.Click += new System.EventHandler(this.BtnLogistica_Click);
            // 
            // BtnEstoqueF
            // 
            this.BtnEstoqueF.BackColor = System.Drawing.Color.Transparent;
            this.BtnEstoqueF.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnEstoqueF.ForeColor = System.Drawing.Color.White;
            this.BtnEstoqueF.Image = null;
            this.BtnEstoqueF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstoqueF.Location = new System.Drawing.Point(277, 280);
            this.BtnEstoqueF.Name = "BtnEstoqueF";
            this.BtnEstoqueF.Size = new System.Drawing.Size(215, 127);
            this.BtnEstoqueF.TabIndex = 4;
            this.BtnEstoqueF.Text = "Sistema Estoque Financeiro";
            this.BtnEstoqueF.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEstoqueF.Click += new System.EventHandler(this.BtnEstoqueF_Click);
            // 
            // BtnValores
            // 
            this.BtnValores.BackColor = System.Drawing.Color.Transparent;
            this.BtnValores.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnValores.ForeColor = System.Drawing.Color.White;
            this.BtnValores.Image = null;
            this.BtnValores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnValores.Location = new System.Drawing.Point(23, 280);
            this.BtnValores.Name = "BtnValores";
            this.BtnValores.Size = new System.Drawing.Size(215, 127);
            this.BtnValores.TabIndex = 4;
            this.BtnValores.Text = "Sistema de Consultar Valores";
            this.BtnValores.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnValores.Click += new System.EventHandler(this.BtnValores_Click);
            // 
            // BtnAmostra
            // 
            this.BtnAmostra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnAmostra.ForeColor = System.Drawing.Color.White;
            this.BtnAmostra.Image = null;
            this.BtnAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAmostra.Location = new System.Drawing.Point(277, 132);
            this.BtnAmostra.Name = "BtnAmostra";
            this.BtnAmostra.Size = new System.Drawing.Size(215, 127);
            this.BtnAmostra.TabIndex = 4;
            this.BtnAmostra.Text = "Sistema de Amostras";
            this.BtnAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAmostra.Click += new System.EventHandler(this.BtnAmostra_Click);
            // 
            // FrmEscolherSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(520, 426);
            this.Controls.Add(this.BtnValores);
            this.Controls.Add(this.BtnEstoqueF);
            this.Controls.Add(this.BtnAmostra);
            this.Controls.Add(this.BtnLogistica);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEscolherSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o Sistema para Trabalhar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEscolherSistema_FormClosing);
            this.Load += new System.EventHandler(this.FrmEscolherSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLogistica;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEstoqueF;
        private Retaguarda.iTalk.iTalk_Button_2 BtnValores;
        private Retaguarda.iTalk.iTalk_Button_2 BtnAmostra;
    }
}