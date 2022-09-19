
namespace Logistica.Sistema_de_Amostras
{
    partial class FrmAmostra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAmostra));
            this.iTalk_TabControl1 = new Retaguarda.iTalk.iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.btnGerarAmostra = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.dtpDataentrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObra = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtConstrutora = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtAmostraId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_TabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(1285, 669);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.rtbComentario);
            this.tabPage1.Controls.Add(this.btnGerarAmostra);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.dtpDataentrega);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtObra);
            this.tabPage1.Controls.Add(this.txtConstrutora);
            this.tabPage1.Controls.Add(this.txtAmostraId);
            this.tabPage1.Controls.Add(this.rbPendente);
            this.tabPage1.Controls.Add(this.rbCancelado);
            this.tabPage1.Controls.Add(this.rbFinalizado);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1142, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do     Envio ";
            // 
            // rtbComentario
            // 
            this.rtbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComentario.Location = new System.Drawing.Point(25, 323);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(618, 280);
            this.rtbComentario.TabIndex = 87;
            this.rtbComentario.Text = "";
            // 
            // btnGerarAmostra
            // 
            this.btnGerarAmostra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGerarAmostra.ForeColor = System.Drawing.Color.Red;
            this.btnGerarAmostra.Location = new System.Drawing.Point(70, 17);
            this.btnGerarAmostra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarAmostra.Name = "btnGerarAmostra";
            this.btnGerarAmostra.Size = new System.Drawing.Size(118, 36);
            this.btnGerarAmostra.TabIndex = 86;
            this.btnGerarAmostra.Text = "GERAR ID";
            this.btnGerarAmostra.UseVisualStyleBackColor = true;
            this.btnGerarAmostra.Click += new System.EventHandler(this.BtnGerarAmostra_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(845, 577);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 22);
            this.label43.TabIndex = 83;
            this.label43.Text = "Deletar";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(696, 577);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(69, 22);
            this.label42.TabIndex = 84;
            this.label42.Text = "Salvar";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Location = new System.Drawing.Point(818, 501);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(119, 68);
            this.btnDeletar.TabIndex = 81;
            this.btnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Location = new System.Drawing.Point(673, 501);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 68);
            this.btnSalvar.TabIndex = 82;
            this.btnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // dtpDataentrega
            // 
            this.dtpDataentrega.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpDataentrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataentrega.Location = new System.Drawing.Point(536, 24);
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
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "Const / Cliente: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(247, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 38);
            this.label7.TabIndex = 34;
            this.label7.Text = "Amostras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 185);
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
            this.label1.Location = new System.Drawing.Point(301, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data do Pedido:";
            // 
            // txtObra
            // 
            this.txtObra.BackColor = System.Drawing.Color.Transparent;
            this.txtObra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtObra.ForeColor = System.Drawing.Color.Black;
            this.txtObra.Location = new System.Drawing.Point(25, 225);
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
            // txtConstrutora
            // 
            this.txtConstrutora.BackColor = System.Drawing.Color.Transparent;
            this.txtConstrutora.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtConstrutora.ForeColor = System.Drawing.Color.Black;
            this.txtConstrutora.Location = new System.Drawing.Point(25, 133);
            this.txtConstrutora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConstrutora.MaxLength = 32767;
            this.txtConstrutora.Multiline = false;
            this.txtConstrutora.Name = "txtConstrutora";
            this.txtConstrutora.ReadOnly = false;
            this.txtConstrutora.Size = new System.Drawing.Size(618, 33);
            this.txtConstrutora.TabIndex = 33;
            this.txtConstrutora.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConstrutora.UseSystemPasswordChar = false;
            // 
            // txtAmostraId
            // 
            this.txtAmostraId.BackColor = System.Drawing.Color.Transparent;
            this.txtAmostraId.Enabled = false;
            this.txtAmostraId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAmostraId.ForeColor = System.Drawing.Color.DimGray;
            this.txtAmostraId.Location = new System.Drawing.Point(3, 17);
            this.txtAmostraId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmostraId.MaxLength = 32767;
            this.txtAmostraId.Multiline = false;
            this.txtAmostraId.Name = "txtAmostraId";
            this.txtAmostraId.ReadOnly = false;
            this.txtAmostraId.Size = new System.Drawing.Size(61, 33);
            this.txtAmostraId.TabIndex = 33;
            this.txtAmostraId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmostraId.UseSystemPasswordChar = false;
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.rbPendente.Location = new System.Drawing.Point(714, 177);
            this.rbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(187, 49);
            this.rbPendente.TabIndex = 31;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbCancelado.ForeColor = System.Drawing.Color.Red;
            this.rbCancelado.Location = new System.Drawing.Point(714, 340);
            this.rbCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(201, 49);
            this.rbCancelado.TabIndex = 30;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Checked = true;
            this.rbFinalizado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.rbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.rbFinalizado.Location = new System.Drawing.Point(714, 253);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(197, 49);
            this.rbFinalizado.TabIndex = 29;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(971, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // FrmAmostra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1285, 669);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAmostra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amostra Cliente ";
            this.Load += new System.EventHandler(this.FrmAmostra_Load);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Retaguarda.iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpDataentrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtObra;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtConstrutora;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtAmostraId;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerarAmostra;
        private System.Windows.Forms.RichTextBox rtbComentario;
        private System.Windows.Forms.Label label7;
    }
}