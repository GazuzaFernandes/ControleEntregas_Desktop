
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
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtFerramentaId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rtbEquipamento = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnImpressao = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.label41 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetirada.Location = new System.Drawing.Point(827, 258);
            this.dtpRetirada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(140, 31);
            this.dtpRetirada.TabIndex = 48;
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
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(244, 147);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(618, 33);
            this.txtNome.TabIndex = 43;
            this.txtNome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtFerramentaId
            // 
            this.txtFerramentaId.BackColor = System.Drawing.Color.Transparent;
            this.txtFerramentaId.Enabled = false;
            this.txtFerramentaId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFerramentaId.ForeColor = System.Drawing.Color.DimGray;
            this.txtFerramentaId.Location = new System.Drawing.Point(12, 11);
            this.txtFerramentaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFerramentaId.MaxLength = 32767;
            this.txtFerramentaId.Multiline = false;
            this.txtFerramentaId.Name = "txtFerramentaId";
            this.txtFerramentaId.ReadOnly = false;
            this.txtFerramentaId.Size = new System.Drawing.Size(61, 33);
            this.txtFerramentaId.TabIndex = 44;
            this.txtFerramentaId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFerramentaId.UseSystemPasswordChar = false;
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.rbPendente.Location = new System.Drawing.Point(371, 34);
            this.rbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(187, 49);
            this.rbPendente.TabIndex = 40;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.rbFinalizado.Location = new System.Drawing.Point(604, 34);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(197, 49);
            this.rbFinalizado.TabIndex = 38;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Devolvido";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rtbEquipamento
            // 
            this.rtbEquipamento.AutoWordSelection = false;
            this.rtbEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.rtbEquipamento.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.rtbEquipamento.ForeColor = System.Drawing.Color.Black;
            this.rtbEquipamento.Location = new System.Drawing.Point(27, 244);
            this.rtbEquipamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbEquipamento.Name = "rtbEquipamento";
            this.rtbEquipamento.ReadOnly = false;
            this.rtbEquipamento.Size = new System.Drawing.Size(659, 118);
            this.rtbEquipamento.TabIndex = 50;
            this.rtbEquipamento.WordWrap = true;
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
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucao.Location = new System.Drawing.Point(856, 325);
            this.dtpDevolucao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(140, 31);
            this.dtpDevolucao.TabIndex = 48;
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
            // btnImpressao
            // 
            this.btnImpressao.BackColor = System.Drawing.Color.Transparent;
            this.btnImpressao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImpressao.Image = global::Logistica.Properties.Resources.icons8_impressão_48;
            this.btnImpressao.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImpressao.Location = new System.Drawing.Point(456, 378);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(122, 71);
            this.btnImpressao.TabIndex = 54;
            this.btnImpressao.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnImpressao.Click += new System.EventHandler(this.BtnImpressao_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Location = new System.Drawing.Point(278, 378);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 71);
            this.btnDeletar.TabIndex = 54;
            this.btnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Location = new System.Drawing.Point(81, 378);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 71);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
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
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnImpressao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbEquipamento);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtFerramentaId);
            this.Controls.Add(this.rbPendente);
            this.Controls.Add(this.rbFinalizado);
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

        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtNome;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtFerramentaId;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private Retaguarda.iTalk.iTalk_RichTextBox rtbEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Retaguarda.iTalk.iTalk_Button_1 btnImpressao;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvar;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}