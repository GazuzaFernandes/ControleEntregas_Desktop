
namespace Logistica.Sistema_Controle_de_Preços
{
    partial class FrmPrincpalValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincpalValores));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.DgvValores = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnProduto = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnLimparPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel12.Controls.Add(this.label65);
            this.panel12.Controls.Add(this.label64);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 702);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1143, 30);
            this.panel12.TabIndex = 54;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
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
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(701, 7);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(0, 17);
            this.label64.TabIndex = 0;
            // 
            // DgvValores
            // 
            this.DgvValores.AllowUserToAddRows = false;
            this.DgvValores.AllowUserToDeleteRows = false;
            this.DgvValores.BackgroundColor = System.Drawing.Color.White;
            this.DgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvValores.Location = new System.Drawing.Point(0, 157);
            this.DgvValores.Name = "DgvValores";
            this.DgvValores.ReadOnly = true;
            this.DgvValores.RowHeadersWidth = 51;
            this.DgvValores.RowTemplate.Height = 24;
            this.DgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvValores.Size = new System.Drawing.Size(1143, 545);
            this.DgvValores.TabIndex = 55;
            this.DgvValores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvValores_CellDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(176, 19);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.txtPesquisar.TabIndex = 56;
            this.txtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // btnProduto
            // 
            this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.Image = null;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(176, 60);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(212, 63);
            this.btnProduto.TabIndex = 58;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // btnLimparPesquisar
            // 
            this.btnLimparPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLimparPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnLimparPesquisar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.btnLimparPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparPesquisar.Location = new System.Drawing.Point(525, 19);
            this.btnLimparPesquisar.Name = "btnLimparPesquisar";
            this.btnLimparPesquisar.Size = new System.Drawing.Size(52, 34);
            this.btnLimparPesquisar.TabIndex = 57;
            this.btnLimparPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimparPesquisar.Click += new System.EventHandler(this.BtnLimparPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 38);
            this.label2.TabIndex = 59;
            this.label2.Text = "Dois Cliques para abrir oque esta selecionado";
            // 
            // FrmPrincpalValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1143, 732);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnLimparPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.DgvValores);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincpalValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal - Valores de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincpalValores_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincpalValores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.DataGridView DgvValores;
        private Retaguarda.iTalk.iTalk_Button_2 btnProduto;
        private Retaguarda.iTalk.iTalk_Button_2 btnLimparPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
    }
}