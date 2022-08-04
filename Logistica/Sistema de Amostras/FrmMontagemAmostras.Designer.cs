
namespace LogisticaEntregas
{
    partial class FrmMontagemAmostras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMontagemAmostras));
            this.iTalk_TabControl1 = new Retaguarda.iTalk.iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtpDataentrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtObra = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtMontador = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtMontagemId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.RbPendente = new System.Windows.Forms.RadioButton();
            this.RbCancelado = new System.Windows.Forms.RadioButton();
            this.RbFinalizado = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Rtbmaterial = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_TabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(1100, 523);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.BtnDeletar);
            this.tabPage1.Controls.Add(this.BtnSalvar);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.DtpDataentrega);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtObra);
            this.tabPage1.Controls.Add(this.TxtMontador);
            this.tabPage1.Controls.Add(this.TxtMontagemId);
            this.tabPage1.Controls.Add(this.RbPendente);
            this.tabPage1.Controls.Add(this.RbCancelado);
            this.tabPage1.Controls.Add(this.RbFinalizado);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(957, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Amostra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(715, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // DtpDataentrega
            // 
            this.DtpDataentrega.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.DtpDataentrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDataentrega.Location = new System.Drawing.Point(432, 44);
            this.DtpDataentrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpDataentrega.Name = "DtpDataentrega";
            this.DtpDataentrega.Size = new System.Drawing.Size(140, 31);
            this.DtpDataentrega.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "Montador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Obra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data do Envio:";
            // 
            // TxtObra
            // 
            this.TxtObra.BackColor = System.Drawing.Color.Transparent;
            this.TxtObra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtObra.ForeColor = System.Drawing.Color.Black;
            this.TxtObra.Location = new System.Drawing.Point(25, 266);
            this.TxtObra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObra.MaxLength = 32767;
            this.TxtObra.Multiline = false;
            this.TxtObra.Name = "TxtObra";
            this.TxtObra.ReadOnly = false;
            this.TxtObra.Size = new System.Drawing.Size(618, 33);
            this.TxtObra.TabIndex = 33;
            this.TxtObra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtObra.UseSystemPasswordChar = false;
            // 
            // TxtMontador
            // 
            this.TxtMontador.BackColor = System.Drawing.Color.Transparent;
            this.TxtMontador.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMontador.ForeColor = System.Drawing.Color.Black;
            this.TxtMontador.Location = new System.Drawing.Point(28, 163);
            this.TxtMontador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMontador.MaxLength = 32767;
            this.TxtMontador.Multiline = false;
            this.TxtMontador.Name = "TxtMontador";
            this.TxtMontador.ReadOnly = false;
            this.TxtMontador.Size = new System.Drawing.Size(618, 33);
            this.TxtMontador.TabIndex = 33;
            this.TxtMontador.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMontador.UseSystemPasswordChar = false;
            // 
            // TxtMontagemId
            // 
            this.TxtMontagemId.BackColor = System.Drawing.Color.Transparent;
            this.TxtMontagemId.Enabled = false;
            this.TxtMontagemId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMontagemId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMontagemId.Location = new System.Drawing.Point(6, 7);
            this.TxtMontagemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMontagemId.MaxLength = 32767;
            this.TxtMontagemId.Multiline = false;
            this.TxtMontagemId.Name = "TxtMontagemId";
            this.TxtMontagemId.ReadOnly = false;
            this.TxtMontagemId.Size = new System.Drawing.Size(61, 33);
            this.TxtMontagemId.TabIndex = 33;
            this.TxtMontagemId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMontagemId.UseSystemPasswordChar = false;
            // 
            // RbPendente
            // 
            this.RbPendente.AutoSize = true;
            this.RbPendente.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.RbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.RbPendente.Location = new System.Drawing.Point(69, 309);
            this.RbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbPendente.Name = "RbPendente";
            this.RbPendente.Size = new System.Drawing.Size(187, 49);
            this.RbPendente.TabIndex = 31;
            this.RbPendente.TabStop = true;
            this.RbPendente.Text = "Pendente";
            this.RbPendente.UseVisualStyleBackColor = true;
            // 
            // RbCancelado
            // 
            this.RbCancelado.AutoSize = true;
            this.RbCancelado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.RbCancelado.ForeColor = System.Drawing.Color.Red;
            this.RbCancelado.Location = new System.Drawing.Point(565, 309);
            this.RbCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbCancelado.Name = "RbCancelado";
            this.RbCancelado.Size = new System.Drawing.Size(201, 49);
            this.RbCancelado.TabIndex = 30;
            this.RbCancelado.TabStop = true;
            this.RbCancelado.Text = "Cancelado";
            this.RbCancelado.UseVisualStyleBackColor = true;
            // 
            // RbFinalizado
            // 
            this.RbFinalizado.AutoSize = true;
            this.RbFinalizado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.RbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.RbFinalizado.Location = new System.Drawing.Point(329, 309);
            this.RbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbFinalizado.Name = "RbFinalizado";
            this.RbFinalizado.Size = new System.Drawing.Size(197, 49);
            this.RbFinalizado.TabIndex = 29;
            this.RbFinalizado.TabStop = true;
            this.RbFinalizado.Text = "Finalizado";
            this.RbFinalizado.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Rtbmaterial);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(957, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela de Amostra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 38);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tipo de Amostra para montar:";
            // 
            // Rtbmaterial
            // 
            this.Rtbmaterial.AutoWordSelection = false;
            this.Rtbmaterial.BackColor = System.Drawing.Color.Transparent;
            this.Rtbmaterial.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.Rtbmaterial.ForeColor = System.Drawing.Color.DimGray;
            this.Rtbmaterial.Location = new System.Drawing.Point(30, 68);
            this.Rtbmaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rtbmaterial.Name = "Rtbmaterial";
            this.Rtbmaterial.ReadOnly = false;
            this.Rtbmaterial.Size = new System.Drawing.Size(810, 378);
            this.Rtbmaterial.TabIndex = 22;
            this.Rtbmaterial.Text = "Informe o Material:";
            this.Rtbmaterial.WordWrap = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(374, 443);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 22);
            this.label43.TabIndex = 87;
            this.label43.Text = "Deletar";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(216, 443);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(69, 22);
            this.label42.TabIndex = 88;
            this.label42.Text = "Salvar";
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(353, 372);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(119, 68);
            this.BtnDeletar.TabIndex = 85;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(191, 372);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(119, 68);
            this.BtnSalvar.TabIndex = 86;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // FrmMontagemAmostras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 523);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMontagemAmostras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Montagem de Amostras";
            this.Load += new System.EventHandler(this.FrmMontagemAmostras_Load);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Retaguarda.iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker DtpDataentrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtObra;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtMontador;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtMontagemId;
        private System.Windows.Forms.RadioButton RbPendente;
        private System.Windows.Forms.RadioButton RbCancelado;
        private System.Windows.Forms.RadioButton RbFinalizado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private Retaguarda.iTalk.iTalk_RichTextBox Rtbmaterial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private Retaguarda.iTalk.iTalk_Button_1 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnSalvar;
    }
}