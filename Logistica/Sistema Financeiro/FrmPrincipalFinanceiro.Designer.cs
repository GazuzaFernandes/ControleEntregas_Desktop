
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
            this.BtnProposta = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnLimparPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.RbPisos = new System.Windows.Forms.RadioButton();
            this.RbEngenharia = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbComercio = new System.Windows.Forms.RadioButton();
            this.RbObra = new System.Windows.Forms.RadioButton();
            this.RbProposta = new System.Windows.Forms.RadioButton();
            this.BtnEstoque = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnCliente = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RbNf = new System.Windows.Forms.RadioButton();
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
            // BtnProposta
            // 
            this.BtnProposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnProposta.BackColor = System.Drawing.Color.Transparent;
            this.BtnProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnProposta.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnProposta.ForeColor = System.Drawing.Color.White;
            this.BtnProposta.Image = null;
            this.BtnProposta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProposta.Location = new System.Drawing.Point(668, 66);
            this.BtnProposta.Name = "BtnProposta";
            this.BtnProposta.Size = new System.Drawing.Size(199, 88);
            this.BtnProposta.TabIndex = 22;
            this.BtnProposta.Text = "Proposta";
            this.BtnProposta.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnProposta.Click += new System.EventHandler(this.BtnProposta_Click);
            // 
            // BtnLimparPesquisar
            // 
            this.BtnLimparPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimparPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLimparPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnLimparPesquisar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.BtnLimparPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimparPesquisar.Location = new System.Drawing.Point(609, 26);
            this.BtnLimparPesquisar.Name = "BtnLimparPesquisar";
            this.BtnLimparPesquisar.Size = new System.Drawing.Size(52, 34);
            this.BtnLimparPesquisar.TabIndex = 23;
            this.BtnLimparPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimparPesquisar.Click += new System.EventHandler(this.BtnLimparPesquisar_Click);
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisar.Location = new System.Drawing.Point(185, 26);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.TxtPesquisar.TabIndex = 21;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // RbPisos
            // 
            this.RbPisos.AutoSize = true;
            this.RbPisos.BackColor = System.Drawing.Color.Transparent;
            this.RbPisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPisos.ForeColor = System.Drawing.Color.Yellow;
            this.RbPisos.Location = new System.Drawing.Point(515, 147);
            this.RbPisos.Name = "RbPisos";
            this.RbPisos.Size = new System.Drawing.Size(17, 16);
            this.RbPisos.TabIndex = 24;
            this.RbPisos.TabStop = true;
            this.RbPisos.UseVisualStyleBackColor = false;
            // 
            // RbEngenharia
            // 
            this.RbEngenharia.AutoSize = true;
            this.RbEngenharia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEngenharia.ForeColor = System.Drawing.Color.Cyan;
            this.RbEngenharia.Location = new System.Drawing.Point(185, 147);
            this.RbEngenharia.Name = "RbEngenharia";
            this.RbEngenharia.Size = new System.Drawing.Size(17, 16);
            this.RbEngenharia.TabIndex = 25;
            this.RbEngenharia.TabStop = true;
            this.RbEngenharia.UseVisualStyleBackColor = true;
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
            // RbComercio
            // 
            this.RbComercio.AutoSize = true;
            this.RbComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbComercio.ForeColor = System.Drawing.Color.Lime;
            this.RbComercio.Location = new System.Drawing.Point(352, 147);
            this.RbComercio.Name = "RbComercio";
            this.RbComercio.Size = new System.Drawing.Size(17, 16);
            this.RbComercio.TabIndex = 25;
            this.RbComercio.TabStop = true;
            this.RbComercio.UseVisualStyleBackColor = true;
            // 
            // RbObra
            // 
            this.RbObra.AutoSize = true;
            this.RbObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbObra.ForeColor = System.Drawing.Color.White;
            this.RbObra.Location = new System.Drawing.Point(185, 81);
            this.RbObra.Name = "RbObra";
            this.RbObra.Size = new System.Drawing.Size(92, 33);
            this.RbObra.TabIndex = 25;
            this.RbObra.TabStop = true;
            this.RbObra.Text = "Obra";
            this.RbObra.UseVisualStyleBackColor = true;
            // 
            // RbProposta
            // 
            this.RbProposta.AutoSize = true;
            this.RbProposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbProposta.ForeColor = System.Drawing.Color.White;
            this.RbProposta.Location = new System.Drawing.Point(293, 81);
            this.RbProposta.Name = "RbProposta";
            this.RbProposta.Size = new System.Drawing.Size(139, 33);
            this.RbProposta.TabIndex = 25;
            this.RbProposta.TabStop = true;
            this.RbProposta.Text = "Proposta";
            this.RbProposta.UseVisualStyleBackColor = true;
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.BtnEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnEstoque.ForeColor = System.Drawing.Color.White;
            this.BtnEstoque.Image = null;
            this.BtnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEstoque.Location = new System.Drawing.Point(890, 66);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Size = new System.Drawing.Size(199, 88);
            this.BtnEstoque.TabIndex = 22;
            this.BtnEstoque.Text = "Estoque ";
            this.BtnEstoque.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Image = null;
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCliente.Location = new System.Drawing.Point(1136, 66);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(199, 88);
            this.BtnCliente.TabIndex = 22;
            this.BtnCliente.Text = "Cadastro de Clientes";
            this.BtnCliente.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Image = global::Logistica.Properties.Resources.icons8_pesquisar_30;
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPesquisar.Location = new System.Drawing.Point(542, 26);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(52, 34);
            this.BtnPesquisar.TabIndex = 23;
            this.BtnPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(538, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 59;
            this.label12.Text = "Rb Pisos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(375, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Rb Comércio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(208, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "Rb Engenharia";
            // 
            // RbNf
            // 
            this.RbNf.AutoSize = true;
            this.RbNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNf.ForeColor = System.Drawing.Color.White;
            this.RbNf.Location = new System.Drawing.Point(438, 81);
            this.RbNf.Name = "RbNf";
            this.RbNf.Size = new System.Drawing.Size(166, 33);
            this.RbNf.TabIndex = 25;
            this.RbNf.TabStop = true;
            this.RbNf.Text = "Nota Fiscal";
            this.RbNf.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipalFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1378, 723);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnEstoque);
            this.Controls.Add(this.BtnProposta);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimparPesquisar);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.RbPisos);
            this.Controls.Add(this.RbComercio);
            this.Controls.Add(this.RbNf);
            this.Controls.Add(this.RbProposta);
            this.Controls.Add(this.RbObra);
            this.Controls.Add(this.RbEngenharia);
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
        private Retaguarda.iTalk.iTalk_Button_2 BtnProposta;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLimparPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.RadioButton RbPisos;
        private System.Windows.Forms.RadioButton RbEngenharia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbComercio;
        private System.Windows.Forms.RadioButton RbObra;
        private System.Windows.Forms.RadioButton RbProposta;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEstoque;
        private Retaguarda.iTalk.iTalk_Button_2 BtnCliente;
        private Retaguarda.iTalk.iTalk_Button_2 BtnPesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RbNf;
    }
}