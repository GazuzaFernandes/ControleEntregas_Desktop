
namespace Logistica.Sistema_de_Amostras
{
    partial class FrmPrincipalAmostra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalAmostra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iTalk_TabControl1 = new Retaguarda.iTalk.iTalk_TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DgvAmostraa = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvAmostra = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvMontagem = new System.Windows.Forms.DataGridView();
            this.label64 = new System.Windows.Forms.Label();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.RbCliente = new System.Windows.Forms.RadioButton();
            this.RbEndereco = new System.Windows.Forms.RadioButton();
            this.BtnLimpar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnEstoque = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnMontagemAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel12.SuspendLayout();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostraa)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMontagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label65);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 33);
            this.panel1.TabIndex = 0;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(319, 8);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(484, 17);
            this.label65.TabIndex = 1;
            this.label65.Text = "Desenvolvedor: Peterson Fernandes. Contato: petersongazuza@gmail.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel12.Controls.Add(this.iTalk_TabControl1);
            this.panel12.Controls.Add(this.label64);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 137);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1291, 489);
            this.panel12.TabIndex = 5;
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage3);
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(1291, 489);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 7;
            this.iTalk_TabControl1.Click += new System.EventHandler(this.iTalk_TabControl1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.DgvAmostraa);
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1148, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Amostras  Clientes ";
            // 
            // DgvAmostraa
            // 
            this.DgvAmostraa.AllowUserToAddRows = false;
            this.DgvAmostraa.AllowUserToDeleteRows = false;
            this.DgvAmostraa.BackgroundColor = System.Drawing.Color.White;
            this.DgvAmostraa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAmostraa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAmostraa.Location = new System.Drawing.Point(0, 0);
            this.DgvAmostraa.Name = "DgvAmostraa";
            this.DgvAmostraa.ReadOnly = true;
            this.DgvAmostraa.RowHeadersWidth = 51;
            this.DgvAmostraa.RowTemplate.Height = 24;
            this.DgvAmostraa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAmostraa.Size = new System.Drawing.Size(1148, 481);
            this.DgvAmostraa.TabIndex = 2;
            this.DgvAmostraa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAmostraa_CellDoubleClick);
            this.DgvAmostraa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvAmostraa_DataBindingComplete);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.DgvAmostra);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amostras           2021";
            // 
            // DgvAmostra
            // 
            this.DgvAmostra.AllowUserToAddRows = false;
            this.DgvAmostra.AllowUserToDeleteRows = false;
            this.DgvAmostra.BackgroundColor = System.Drawing.Color.White;
            this.DgvAmostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAmostra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAmostra.Location = new System.Drawing.Point(3, 3);
            this.DgvAmostra.Name = "DgvAmostra";
            this.DgvAmostra.ReadOnly = true;
            this.DgvAmostra.RowHeadersWidth = 51;
            this.DgvAmostra.RowTemplate.Height = 24;
            this.DgvAmostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAmostra.Size = new System.Drawing.Size(1142, 475);
            this.DgvAmostra.TabIndex = 1;
            this.DgvAmostra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAmostra_CellDoubleClick);
            this.DgvAmostra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvAmostra_DataBindingComplete);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.DgvMontagem);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produção de Amostras";
            // 
            // DgvMontagem
            // 
            this.DgvMontagem.AllowUserToAddRows = false;
            this.DgvMontagem.AllowUserToDeleteRows = false;
            this.DgvMontagem.BackgroundColor = System.Drawing.Color.White;
            this.DgvMontagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMontagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMontagem.Location = new System.Drawing.Point(3, 3);
            this.DgvMontagem.Name = "DgvMontagem";
            this.DgvMontagem.ReadOnly = true;
            this.DgvMontagem.RowHeadersWidth = 51;
            this.DgvMontagem.RowTemplate.Height = 24;
            this.DgvMontagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMontagem.Size = new System.Drawing.Size(1142, 475);
            this.DgvMontagem.TabIndex = 2;
            this.DgvMontagem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMontagemAmostra_CellDoubleClick);
            this.DgvMontagem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvMontagemAmostra_DataBindingComplete);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(1273, 7);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(547, 17);
            this.label64.TabIndex = 0;
            this.label64.Text = "Sistema desemvolvido para facilitar a Logistica da empresa: Rb Pisos e Acabamento" +
    "s";
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisar.Location = new System.Drawing.Point(169, 23);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.TxtPesquisar.TabIndex = 9;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // RbCliente
            // 
            this.RbCliente.AutoSize = true;
            this.RbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCliente.ForeColor = System.Drawing.Color.White;
            this.RbCliente.Location = new System.Drawing.Point(169, 77);
            this.RbCliente.Name = "RbCliente";
            this.RbCliente.Size = new System.Drawing.Size(101, 29);
            this.RbCliente.TabIndex = 9;
            this.RbCliente.TabStop = true;
            this.RbCliente.Text = "Cliente";
            this.RbCliente.UseVisualStyleBackColor = true;
            // 
            // RbEndereco
            // 
            this.RbEndereco.AutoSize = true;
            this.RbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEndereco.ForeColor = System.Drawing.Color.White;
            this.RbEndereco.Location = new System.Drawing.Point(294, 77);
            this.RbEndereco.Name = "RbEndereco";
            this.RbEndereco.Size = new System.Drawing.Size(125, 29);
            this.RbEndereco.TabIndex = 11;
            this.RbEndereco.TabStop = true;
            this.RbEndereco.Text = "Endereço";
            this.RbEndereco.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimpar.Location = new System.Drawing.Point(518, 63);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(52, 34);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.BtnEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnEstoque.ForeColor = System.Drawing.Color.White;
            this.BtnEstoque.Image = null;
            this.BtnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstoque.Location = new System.Drawing.Point(799, 23);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Size = new System.Drawing.Size(167, 96);
            this.BtnEstoque.TabIndex = 7;
            this.BtnEstoque.Text = "Atualizar Estoque";
            this.BtnEstoque.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // BtnAmostra
            // 
            this.BtnAmostra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnAmostra.ForeColor = System.Drawing.Color.White;
            this.BtnAmostra.Image = null;
            this.BtnAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAmostra.Location = new System.Drawing.Point(612, 23);
            this.BtnAmostra.Name = "BtnAmostra";
            this.BtnAmostra.Size = new System.Drawing.Size(167, 96);
            this.BtnAmostra.TabIndex = 7;
            this.BtnAmostra.Text = "Entregar Amostras";
            this.BtnAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAmostra.Click += new System.EventHandler(this.BtnAmostra_Click);
            // 
            // BtnMontagemAmostra
            // 
            this.BtnMontagemAmostra.BackColor = System.Drawing.Color.Transparent;
            this.BtnMontagemAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnMontagemAmostra.ForeColor = System.Drawing.Color.White;
            this.BtnMontagemAmostra.Image = null;
            this.BtnMontagemAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMontagemAmostra.Location = new System.Drawing.Point(983, 23);
            this.BtnMontagemAmostra.Name = "BtnMontagemAmostra";
            this.BtnMontagemAmostra.Size = new System.Drawing.Size(159, 96);
            this.BtnMontagemAmostra.TabIndex = 6;
            this.BtnMontagemAmostra.Text = "Montagem Amostra";
            this.BtnMontagemAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnMontagemAmostra.Click += new System.EventHandler(this.BtnMontagemAmostra_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Image = global::Logistica.Properties.Resources.icons8_pesquisar_30;
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPesquisar.Location = new System.Drawing.Point(518, 23);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(52, 34);
            this.BtnPesquisar.TabIndex = 10;
            this.BtnPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // FrmPrincipalAmostra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1291, 659);
            this.Controls.Add(this.RbEndereco);
            this.Controls.Add(this.RbCliente);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.BtnEstoque);
            this.Controls.Add(this.BtnAmostra);
            this.Controls.Add(this.BtnMontagemAmostra);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipalAmostra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal - Historico de Amostras ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalAmostra_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalAmostra_Load);
            this.Click += new System.EventHandler(this.FrmPrincipalAmostra_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostraa)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMontagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Panel panel12;
        private Retaguarda.iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvAmostra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label64;
        private Retaguarda.iTalk.iTalk_Button_2 BtnMontagemAmostra;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.DataGridView DgvMontagem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DgvAmostraa;
        private Retaguarda.iTalk.iTalk_Button_2 BtnAmostra;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEstoque;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLimpar;
        private System.Windows.Forms.RadioButton RbCliente;
        private System.Windows.Forms.RadioButton RbEndereco;
        private Retaguarda.iTalk.iTalk_Button_2 BtnPesquisar;
    }
}