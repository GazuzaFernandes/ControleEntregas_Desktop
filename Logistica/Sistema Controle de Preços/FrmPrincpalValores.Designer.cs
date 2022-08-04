
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
            this.BtnProduto = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnLimparPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.RbMaterial = new System.Windows.Forms.RadioButton();
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
            this.pictureBox2.Size = new System.Drawing.Size(155, 146);
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
            this.DgvValores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvValores.Location = new System.Drawing.Point(0, 182);
            this.DgvValores.Name = "DgvValores";
            this.DgvValores.ReadOnly = true;
            this.DgvValores.RowHeadersWidth = 51;
            this.DgvValores.RowTemplate.Height = 24;
            this.DgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvValores.Size = new System.Drawing.Size(1143, 520);
            this.DgvValores.TabIndex = 55;
            this.DgvValores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvValores_CellDoubleClick);
            // 
            // BtnProduto
            // 
            this.BtnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtnProduto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnProduto.ForeColor = System.Drawing.Color.White;
            this.BtnProduto.Image = null;
            this.BtnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduto.Location = new System.Drawing.Point(192, 86);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(212, 63);
            this.BtnProduto.TabIndex = 58;
            this.BtnProduto.Text = "Cadastrar Produto";
            this.BtnProduto.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // BtnLimparPesquisar
            // 
            this.BtnLimparPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimparPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLimparPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnLimparPesquisar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.BtnLimparPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimparPesquisar.Location = new System.Drawing.Point(557, 34);
            this.BtnLimparPesquisar.Name = "BtnLimparPesquisar";
            this.BtnLimparPesquisar.Size = new System.Drawing.Size(52, 34);
            this.BtnLimparPesquisar.TabIndex = 57;
            this.BtnLimparPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimparPesquisar.Click += new System.EventHandler(this.BtnLimparPesquisar_Click);
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisar.Location = new System.Drawing.Point(192, 34);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.TxtPesquisar.TabIndex = 56;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // RbMaterial
            // 
            this.RbMaterial.AutoSize = true;
            this.RbMaterial.Checked = true;
            this.RbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMaterial.ForeColor = System.Drawing.Color.White;
            this.RbMaterial.Location = new System.Drawing.Point(631, 49);
            this.RbMaterial.Name = "RbMaterial";
            this.RbMaterial.Size = new System.Drawing.Size(128, 33);
            this.RbMaterial.TabIndex = 59;
            this.RbMaterial.TabStop = true;
            this.RbMaterial.Text = "Material";
            this.RbMaterial.UseVisualStyleBackColor = true;
            // 
            // FrmPrincpalValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1143, 732);
            this.Controls.Add(this.RbMaterial);
            this.Controls.Add(this.BtnProduto);
            this.Controls.Add(this.BtnLimparPesquisar);
            this.Controls.Add(this.TxtPesquisar);
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
        private Retaguarda.iTalk.iTalk_Button_2 BtnProduto;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLimparPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.RadioButton RbMaterial;
    }
}