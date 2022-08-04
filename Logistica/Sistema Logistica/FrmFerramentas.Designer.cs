
namespace LogisticaEntregas
{
    partial class FrmFerramentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFerramentas));
            this.DtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtFerramentaId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.RbPendente = new System.Windows.Forms.RadioButton();
            this.RbFinalizado = new System.Windows.Forms.RadioButton();
            this.RtbEquipamento = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnImpressao = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.label41 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpRetirada
            // 
            this.DtpRetirada.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.DtpRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRetirada.Location = new System.Drawing.Point(827, 258);
            this.DtpRetirada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpRetirada.Name = "DtpRetirada";
            this.DtpRetirada.Size = new System.Drawing.Size(140, 31);
            this.DtpRetirada.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 38);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nome Colocador / Raspador / Etc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(692, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Retirada:";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.Transparent;
            this.TxtNome.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtNome.ForeColor = System.Drawing.Color.Black;
            this.TxtNome.Location = new System.Drawing.Point(244, 147);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNome.MaxLength = 32767;
            this.TxtNome.Multiline = false;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.ReadOnly = false;
            this.TxtNome.Size = new System.Drawing.Size(618, 33);
            this.TxtNome.TabIndex = 43;
            this.TxtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNome.UseSystemPasswordChar = false;
            // 
            // TxtFerramentaId
            // 
            this.TxtFerramentaId.BackColor = System.Drawing.Color.Transparent;
            this.TxtFerramentaId.Enabled = false;
            this.TxtFerramentaId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtFerramentaId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFerramentaId.Location = new System.Drawing.Point(12, 11);
            this.TxtFerramentaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFerramentaId.MaxLength = 32767;
            this.TxtFerramentaId.Multiline = false;
            this.TxtFerramentaId.Name = "TxtFerramentaId";
            this.TxtFerramentaId.ReadOnly = false;
            this.TxtFerramentaId.Size = new System.Drawing.Size(61, 33);
            this.TxtFerramentaId.TabIndex = 44;
            this.TxtFerramentaId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFerramentaId.UseSystemPasswordChar = false;
            // 
            // RbPendente
            // 
            this.RbPendente.AutoSize = true;
            this.RbPendente.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.RbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.RbPendente.Location = new System.Drawing.Point(371, 34);
            this.RbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbPendente.Name = "RbPendente";
            this.RbPendente.Size = new System.Drawing.Size(187, 49);
            this.RbPendente.TabIndex = 40;
            this.RbPendente.TabStop = true;
            this.RbPendente.Text = "Pendente";
            this.RbPendente.UseVisualStyleBackColor = true;
            // 
            // RbFinalizado
            // 
            this.RbFinalizado.AutoSize = true;
            this.RbFinalizado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.RbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.RbFinalizado.Location = new System.Drawing.Point(604, 34);
            this.RbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbFinalizado.Name = "RbFinalizado";
            this.RbFinalizado.Size = new System.Drawing.Size(197, 49);
            this.RbFinalizado.TabIndex = 38;
            this.RbFinalizado.TabStop = true;
            this.RbFinalizado.Text = "Devolvido";
            this.RbFinalizado.UseVisualStyleBackColor = true;
            // 
            // RtbEquipamento
            // 
            this.RtbEquipamento.AutoWordSelection = false;
            this.RtbEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.RtbEquipamento.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.RtbEquipamento.ForeColor = System.Drawing.Color.Black;
            this.RtbEquipamento.Location = new System.Drawing.Point(27, 244);
            this.RtbEquipamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RtbEquipamento.Name = "RtbEquipamento";
            this.RtbEquipamento.ReadOnly = false;
            this.RtbEquipamento.Size = new System.Drawing.Size(659, 118);
            this.RtbEquipamento.TabIndex = 50;
            this.RtbEquipamento.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "Equipamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(692, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 38);
            this.label4.TabIndex = 51;
            this.label4.Text = "Devolução:";
            // 
            // DtpDevolucao
            // 
            this.DtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.DtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDevolucao.Location = new System.Drawing.Point(856, 325);
            this.DtpDevolucao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpDevolucao.Name = "DtpDevolucao";
            this.DtpDevolucao.Size = new System.Drawing.Size(140, 31);
            this.DtpDevolucao.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(1045, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // BtnImpressao
            // 
            this.BtnImpressao.BackColor = System.Drawing.Color.Transparent;
            this.BtnImpressao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnImpressao.Image = global::Logistica.Properties.Resources.icons8_impressão_48;
            this.BtnImpressao.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnImpressao.Location = new System.Drawing.Point(456, 378);
            this.BtnImpressao.Name = "BtnImpressao";
            this.BtnImpressao.Size = new System.Drawing.Size(122, 71);
            this.BtnImpressao.TabIndex = 54;
            this.BtnImpressao.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnImpressao.Click += new System.EventHandler(this.BtnImpressao_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(278, 378);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(122, 71);
            this.BtnDeletar.TabIndex = 54;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(81, 378);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(122, 71);
            this.BtnSalvar.TabIndex = 54;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(114, 452);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(57, 23);
            this.label41.TabIndex = 82;
            this.label41.Text = "Salvar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(306, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "Deletar ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(478, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 82;
            this.label6.Text = "Impressão";
            // 
            // FrmFerramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1211, 534);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnImpressao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RtbEquipamento);
            this.Controls.Add(this.DtpDevolucao);
            this.Controls.Add(this.DtpRetirada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtFerramentaId);
            this.Controls.Add(this.RbPendente);
            this.Controls.Add(this.RbFinalizado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFerramentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas";
            this.Load += new System.EventHandler(this.FrmFerramentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpRetirada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtNome;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtFerramentaId;
        private System.Windows.Forms.RadioButton RbPendente;
        private System.Windows.Forms.RadioButton RbFinalizado;
        private Retaguarda.iTalk.iTalk_RichTextBox RtbEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDevolucao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Retaguarda.iTalk.iTalk_Button_1 BtnImpressao;
        private Retaguarda.iTalk.iTalk_Button_1 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnSalvar;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}