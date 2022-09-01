
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
            this.BtnValores = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnEstoqueF = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnLogistica = new Retaguarda.iTalk.iTalk_Button_2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnValores
            // 
            this.BtnValores.BackColor = System.Drawing.Color.Transparent;
            this.BtnValores.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnValores.ForeColor = System.Drawing.Color.White;
            this.BtnValores.Image = null;
            this.BtnValores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnValores.Location = new System.Drawing.Point(25, 273);
            this.BtnValores.Name = "BtnValores";
            this.BtnValores.Size = new System.Drawing.Size(215, 127);
            this.BtnValores.TabIndex = 4;
            this.BtnValores.Text = "Sistema de Consultar Valores";
            this.BtnValores.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnValores.Click += new System.EventHandler(this.BtnValores_Click);
            // 
            // BtnEstoqueF
            // 
            this.BtnEstoqueF.BackColor = System.Drawing.Color.Transparent;
            this.BtnEstoqueF.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnEstoqueF.ForeColor = System.Drawing.Color.White;
            this.BtnEstoqueF.Image = null;
            this.BtnEstoqueF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstoqueF.Location = new System.Drawing.Point(260, 273);
            this.BtnEstoqueF.Name = "BtnEstoqueF";
            this.BtnEstoqueF.Size = new System.Drawing.Size(215, 127);
            this.BtnEstoqueF.TabIndex = 4;
            this.BtnEstoqueF.Text = "Sistema Estoque Financeiro";
            this.BtnEstoqueF.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEstoqueF.Click += new System.EventHandler(this.BtnEstoqueF_Click);
            // 
            // BtnAmostra
            // 
            this.BtnAmostra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnAmostra.ForeColor = System.Drawing.Color.White;
            this.BtnAmostra.Image = null;
            this.BtnAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAmostra.Location = new System.Drawing.Point(260, 140);
            this.BtnAmostra.Name = "BtnAmostra";
            this.BtnAmostra.Size = new System.Drawing.Size(215, 127);
            this.BtnAmostra.TabIndex = 4;
            this.BtnAmostra.Text = "Sistema de Amostras";
            this.BtnAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAmostra.Click += new System.EventHandler(this.BtnAmostra_Click);
            // 
            // BtnLogistica
            // 
            this.BtnLogistica.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogistica.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLogistica.ForeColor = System.Drawing.Color.White;
            this.BtnLogistica.Image = null;
            this.BtnLogistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogistica.Location = new System.Drawing.Point(25, 140);
            this.BtnLogistica.Name = "BtnLogistica";
            this.BtnLogistica.Size = new System.Drawing.Size(215, 127);
            this.BtnLogistica.TabIndex = 4;
            this.BtnLogistica.Text = "Sistema de Entrega de Materiais";
            this.BtnLogistica.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLogistica.Click += new System.EventHandler(this.BtnLogistica_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.BtnValores);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnAmostra);
            this.panel1.Controls.Add(this.BtnEstoqueF);
            this.panel1.Controls.Add(this.BtnLogistica);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 423);
            this.panel1.TabIndex = 5;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Image = global::Logistica.Properties.Resources.icons8_fechar_janela_48;
            this.BtnFechar.Location = new System.Drawing.Point(432, 15);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(52, 43);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = global::Logistica.Properties.Resources.icons8_subtração_48;
            this.BtnMinimizar.Location = new System.Drawing.Point(374, 15);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(52, 43);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEscolherSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(535, 447);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEscolherSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o Sistema para Trabalhar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLogistica;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEstoqueF;
        private Retaguarda.iTalk.iTalk_Button_2 BtnValores;
        private Retaguarda.iTalk.iTalk_Button_2 BtnAmostra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnMinimizar;
    }
}