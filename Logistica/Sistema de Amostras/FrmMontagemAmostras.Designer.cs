
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
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDataentrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObra = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMontador = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMontagemId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbmaterial = new Retaguarda.iTalk.iTalk_RichTextBox();
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
            this.tabPage1.Controls.Add(this.dtpDataentrega);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtObra);
            this.tabPage1.Controls.Add(this.txtMontador);
            this.tabPage1.Controls.Add(this.txtMontagemId);
            this.tabPage1.Controls.Add(this.rbPendente);
            this.tabPage1.Controls.Add(this.rbCancelado);
            this.tabPage1.Controls.Add(this.rbFinalizado);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(957, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Amostra";
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
            // dtpDataentrega
            // 
            this.dtpDataentrega.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpDataentrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataentrega.Location = new System.Drawing.Point(432, 44);
            this.dtpDataentrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataentrega.Name = "dtpDataentrega";
            this.dtpDataentrega.Size = new System.Drawing.Size(140, 31);
            this.dtpDataentrega.TabIndex = 35;
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
            // txtObra
            // 
            this.txtObra.BackColor = System.Drawing.Color.Transparent;
            this.txtObra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtObra.ForeColor = System.Drawing.Color.Black;
            this.txtObra.Location = new System.Drawing.Point(25, 266);
            this.txtObra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObra.MaxLength = 32767;
            this.txtObra.Multiline = false;
            this.txtObra.Name = "txtObra";
            this.txtObra.ReadOnly = false;
            this.txtObra.Size = new System.Drawing.Size(618, 33);
            this.txtObra.TabIndex = 33;
            this.txtObra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObra.UseSystemPasswordChar = false;
            // 
            // txtMontador
            // 
            this.txtMontador.BackColor = System.Drawing.Color.Transparent;
            this.txtMontador.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMontador.ForeColor = System.Drawing.Color.Black;
            this.txtMontador.Location = new System.Drawing.Point(28, 163);
            this.txtMontador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontador.MaxLength = 32767;
            this.txtMontador.Multiline = false;
            this.txtMontador.Name = "txtMontador";
            this.txtMontador.ReadOnly = false;
            this.txtMontador.Size = new System.Drawing.Size(618, 33);
            this.txtMontador.TabIndex = 33;
            this.txtMontador.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontador.UseSystemPasswordChar = false;
            // 
            // txtMontagemId
            // 
            this.txtMontagemId.BackColor = System.Drawing.Color.Transparent;
            this.txtMontagemId.Enabled = false;
            this.txtMontagemId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMontagemId.ForeColor = System.Drawing.Color.DimGray;
            this.txtMontagemId.Location = new System.Drawing.Point(6, 7);
            this.txtMontagemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontagemId.MaxLength = 32767;
            this.txtMontagemId.Multiline = false;
            this.txtMontagemId.Name = "txtMontagemId";
            this.txtMontagemId.ReadOnly = false;
            this.txtMontagemId.Size = new System.Drawing.Size(61, 33);
            this.txtMontagemId.TabIndex = 33;
            this.txtMontagemId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontagemId.UseSystemPasswordChar = false;
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.rbPendente.Location = new System.Drawing.Point(69, 309);
            this.rbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(187, 49);
            this.rbPendente.TabIndex = 31;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbCancelado.ForeColor = System.Drawing.Color.Red;
            this.rbCancelado.Location = new System.Drawing.Point(565, 309);
            this.rbCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(201, 49);
            this.rbCancelado.TabIndex = 30;
            this.rbCancelado.TabStop = true;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.rbFinalizado.Location = new System.Drawing.Point(329, 309);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(197, 49);
            this.rbFinalizado.TabIndex = 29;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rtbmaterial);
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
            // rtbmaterial
            // 
            this.rtbmaterial.AutoWordSelection = false;
            this.rtbmaterial.BackColor = System.Drawing.Color.Transparent;
            this.rtbmaterial.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.rtbmaterial.ForeColor = System.Drawing.Color.DimGray;
            this.rtbmaterial.Location = new System.Drawing.Point(30, 68);
            this.rtbmaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbmaterial.Name = "rtbmaterial";
            this.rtbmaterial.ReadOnly = false;
            this.rtbmaterial.Size = new System.Drawing.Size(810, 378);
            this.rtbmaterial.TabIndex = 22;
            this.rtbmaterial.Text = "Informe o Material:";
            this.rtbmaterial.WordWrap = true;
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
        private System.Windows.Forms.DateTimePicker dtpDataentrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtObra;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMontador;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMontagemId;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private Retaguarda.iTalk.iTalk_RichTextBox rtbmaterial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private Retaguarda.iTalk.iTalk_Button_1 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnSalvar;
    }
}