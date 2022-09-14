
namespace Logistica.Sistema_Financeiro_Estoque
{
    partial class FrmPrincipalFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalFinanceiro));
            this.panel12 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnProposta = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnLimparPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbPisos = new System.Windows.Forms.RadioButton();
            this.rbEngenharia = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.rbObra = new System.Windows.Forms.RadioButton();
            this.rbProposta = new System.Windows.Forms.RadioButton();
            this.btnEstoque = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnCliente = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.rbNf = new System.Windows.Forms.RadioButton();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label65);
            this.panel12.Controls.Add(this.label64);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 693);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1378, 30);
            this.panel12.TabIndex = 2;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(12, 7);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(484, 17);
            this.label65.TabIndex = 0;
            this.label65.Text = "Desenvolvedor: Peterson Fernandes. Contato: petersongazuza@gmail.com";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(771, 7);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(547, 17);
            this.label64.TabIndex = 0;
            this.label64.Text = "Sistema desemvolvido para facilitar a Logistica da empresa: Rb Pisos e Acabamento" +
    "s";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 502);
            this.panel1.TabIndex = 3;
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AllowUserToDeleteRows = false;
            this.DgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowHeadersWidth = 51;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrincipal.Size = new System.Drawing.Size(1378, 502);
            this.DgvPrincipal.TabIndex = 0;
            this.DgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellDoubleClick);
            this.DgvPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvPrincipal_DataBindingComplete);
            // 
            // btnProposta
            // 
            this.btnProposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProposta.BackColor = System.Drawing.Color.Transparent;
            this.btnProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProposta.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnProposta.ForeColor = System.Drawing.Color.White;
            this.btnProposta.Image = null;
            this.btnProposta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProposta.Location = new System.Drawing.Point(683, 66);
            this.btnProposta.Name = "btnProposta";
            this.btnProposta.Size = new System.Drawing.Size(199, 88);
            this.btnProposta.TabIndex = 22;
            this.btnProposta.Text = "Proposta";
            this.btnProposta.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnProposta.Click += new System.EventHandler(this.BtnProposta_Click);
            // 
            // btnLimparPesquisar
            // 
            this.btnLimparPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLimparPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnLimparPesquisar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.btnLimparPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparPesquisar.Location = new System.Drawing.Point(609, 26);
            this.btnLimparPesquisar.Name = "btnLimparPesquisar";
            this.btnLimparPesquisar.Size = new System.Drawing.Size(52, 34);
            this.btnLimparPesquisar.TabIndex = 23;
            this.btnLimparPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimparPesquisar.Click += new System.EventHandler(this.BtnLimparPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(185, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.txtPesquisar.TabIndex = 21;
            this.txtPesquisar.Text = "Digite para Pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // rbPisos
            // 
            this.rbPisos.AutoSize = true;
            this.rbPisos.BackColor = System.Drawing.Color.Transparent;
            this.rbPisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPisos.ForeColor = System.Drawing.Color.Yellow;
            this.rbPisos.Location = new System.Drawing.Point(561, 130);
            this.rbPisos.Name = "rbPisos";
            this.rbPisos.Size = new System.Drawing.Size(99, 33);
            this.rbPisos.TabIndex = 24;
            this.rbPisos.TabStop = true;
            this.rbPisos.Text = "Pisos";
            this.rbPisos.UseVisualStyleBackColor = false;
            // 
            // rbEngenharia
            // 
            this.rbEngenharia.AutoSize = true;
            this.rbEngenharia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEngenharia.ForeColor = System.Drawing.Color.Cyan;
            this.rbEngenharia.Location = new System.Drawing.Point(185, 130);
            this.rbEngenharia.Name = "rbEngenharia";
            this.rbEngenharia.Size = new System.Drawing.Size(167, 33);
            this.rbEngenharia.TabIndex = 25;
            this.rbEngenharia.TabStop = true;
            this.rbEngenharia.Text = "Engenharia";
            this.rbEngenharia.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComercio.ForeColor = System.Drawing.Color.Lime;
            this.rbComercio.Location = new System.Drawing.Point(381, 130);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(147, 33);
            this.rbComercio.TabIndex = 25;
            this.rbComercio.TabStop = true;
            this.rbComercio.Text = "Comercio";
            this.rbComercio.UseVisualStyleBackColor = true;
            // 
            // rbObra
            // 
            this.rbObra.AutoSize = true;
            this.rbObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObra.ForeColor = System.Drawing.Color.White;
            this.rbObra.Location = new System.Drawing.Point(185, 81);
            this.rbObra.Name = "rbObra";
            this.rbObra.Size = new System.Drawing.Size(92, 33);
            this.rbObra.TabIndex = 25;
            this.rbObra.TabStop = true;
            this.rbObra.Text = "Obra";
            this.rbObra.UseVisualStyleBackColor = true;
            // 
            // rbProposta
            // 
            this.rbProposta.AutoSize = true;
            this.rbProposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProposta.ForeColor = System.Drawing.Color.White;
            this.rbProposta.Location = new System.Drawing.Point(307, 81);
            this.rbProposta.Name = "rbProposta";
            this.rbProposta.Size = new System.Drawing.Size(139, 33);
            this.rbProposta.TabIndex = 25;
            this.rbProposta.TabStop = true;
            this.rbProposta.Text = "Proposta";
            this.rbProposta.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = null;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstoque.Location = new System.Drawing.Point(913, 66);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(199, 88);
            this.btnEstoque.TabIndex = 22;
            this.btnEstoque.Text = "Estoque ";
            this.btnEstoque.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = null;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(1136, 66);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(199, 88);
            this.btnCliente.TabIndex = 22;
            this.btnCliente.Text = "Cadastro de Clientes";
            this.btnCliente.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Logistica.Properties.Resources.icons8_pesquisar_30;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(542, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(52, 34);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // rbNf
            // 
            this.rbNf.AutoSize = true;
            this.rbNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNf.ForeColor = System.Drawing.Color.White;
            this.rbNf.Location = new System.Drawing.Point(475, 81);
            this.rbNf.Name = "rbNf";
            this.rbNf.Size = new System.Drawing.Size(166, 33);
            this.rbNf.TabIndex = 25;
            this.rbNf.TabStop = true;
            this.rbNf.Text = "Nota Fiscal";
            this.rbNf.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipalFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1378, 723);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnProposta);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimparPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.rbPisos);
            this.Controls.Add(this.rbComercio);
            this.Controls.Add(this.rbNf);
            this.Controls.Add(this.rbProposta);
            this.Controls.Add(this.rbObra);
            this.Controls.Add(this.rbEngenharia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipalFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal - Sistema Financeiro, Controle de Estoque e Nota Fiscal.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalFinanceiro_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalFinanceiro_Load);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvPrincipal;
        private Retaguarda.iTalk.iTalk_Button_2 btnProposta;
        private Retaguarda.iTalk.iTalk_Button_2 btnLimparPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbPisos;
        private System.Windows.Forms.RadioButton rbEngenharia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbComercio;
        private System.Windows.Forms.RadioButton rbObra;
        private System.Windows.Forms.RadioButton rbProposta;
        private Retaguarda.iTalk.iTalk_Button_2 btnEstoque;
        private Retaguarda.iTalk.iTalk_Button_2 btnCliente;
        private Retaguarda.iTalk.iTalk_Button_2 btnPesquisar;
        private System.Windows.Forms.RadioButton rbNf;
    }
}