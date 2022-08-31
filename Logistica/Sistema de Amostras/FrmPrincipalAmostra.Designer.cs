
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
            this.DgvAmostra = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvAmostra2021 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvMontagem = new System.Windows.Forms.DataGridView();
            this.label64 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbAmostra = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnLimpar = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnEstoque = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnMontagemAmostra = new Retaguarda.iTalk.iTalk_Button_2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel12.SuspendLayout();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra2021)).BeginInit();
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
            this.tabPage3.Controls.Add(this.DgvAmostra);
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1148, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Amostras  Clientes ";
            // 
            // DgvAmostra
            // 
            this.DgvAmostra.AllowUserToAddRows = false;
            this.DgvAmostra.AllowUserToDeleteRows = false;
            this.DgvAmostra.BackgroundColor = System.Drawing.Color.White;
            this.DgvAmostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAmostra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAmostra.Location = new System.Drawing.Point(0, 0);
            this.DgvAmostra.Name = "DgvAmostra";
            this.DgvAmostra.ReadOnly = true;
            this.DgvAmostra.RowHeadersWidth = 51;
            this.DgvAmostra.RowTemplate.Height = 24;
            this.DgvAmostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAmostra.Size = new System.Drawing.Size(1148, 481);
            this.DgvAmostra.TabIndex = 2;
            this.DgvAmostra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAmostraa_CellDoubleClick);
            this.DgvAmostra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvAmostraa_DataBindingComplete);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.DgvAmostra2021);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amostras           2021";
            // 
            // DgvAmostra2021
            // 
            this.DgvAmostra2021.AllowUserToAddRows = false;
            this.DgvAmostra2021.AllowUserToDeleteRows = false;
            this.DgvAmostra2021.BackgroundColor = System.Drawing.Color.White;
            this.DgvAmostra2021.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAmostra2021.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAmostra2021.Location = new System.Drawing.Point(3, 3);
            this.DgvAmostra2021.Name = "DgvAmostra2021";
            this.DgvAmostra2021.ReadOnly = true;
            this.DgvAmostra2021.RowHeadersWidth = 51;
            this.DgvAmostra2021.RowTemplate.Height = 24;
            this.DgvAmostra2021.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAmostra2021.Size = new System.Drawing.Size(1142, 475);
            this.DgvAmostra2021.TabIndex = 1;
            this.DgvAmostra2021.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAmostra_CellDoubleClick);
            this.DgvAmostra2021.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvAmostra_DataBindingComplete);
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
            // txtPesquisar
            // 
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(169, 23);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.txtPesquisar.TabIndex = 9;
            this.txtPesquisar.Text = "Digite para Pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.ForeColor = System.Drawing.Color.White;
            this.rbCliente.Location = new System.Drawing.Point(169, 77);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(101, 29);
            this.rbCliente.TabIndex = 9;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEndereco.ForeColor = System.Drawing.Color.White;
            this.rbEndereco.Location = new System.Drawing.Point(289, 77);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(125, 29);
            this.rbEndereco.TabIndex = 11;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            // 
            // rbAmostra
            // 
            this.rbAmostra.AutoSize = true;
            this.rbAmostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmostra.ForeColor = System.Drawing.Color.White;
            this.rbAmostra.Location = new System.Drawing.Point(457, 77);
            this.rbAmostra.Name = "rbAmostra";
            this.rbAmostra.Size = new System.Drawing.Size(124, 29);
            this.rbAmostra.TabIndex = 11;
            this.rbAmostra.TabStop = true;
            this.rbAmostra.Text = "Amostras";
            this.rbAmostra.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::Logistica.Properties.Resources.icons8_pesquisar_30;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(518, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(52, 34);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_30;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Location = new System.Drawing.Point(585, 23);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(52, 34);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = null;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(869, 23);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(167, 96);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Atualizar Estoque";
            this.btnEstoque.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnAmostra
            // 
            this.btnAmostra.BackColor = System.Drawing.Color.Transparent;
            this.btnAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAmostra.ForeColor = System.Drawing.Color.White;
            this.btnAmostra.Image = null;
            this.btnAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmostra.Location = new System.Drawing.Point(682, 23);
            this.btnAmostra.Name = "btnAmostra";
            this.btnAmostra.Size = new System.Drawing.Size(167, 96);
            this.btnAmostra.TabIndex = 7;
            this.btnAmostra.Text = "Entregar Amostras";
            this.btnAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAmostra.Click += new System.EventHandler(this.BtnAmostra_Click);
            // 
            // btnMontagemAmostra
            // 
            this.btnMontagemAmostra.BackColor = System.Drawing.Color.Transparent;
            this.btnMontagemAmostra.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMontagemAmostra.ForeColor = System.Drawing.Color.White;
            this.btnMontagemAmostra.Image = null;
            this.btnMontagemAmostra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMontagemAmostra.Location = new System.Drawing.Point(1053, 23);
            this.btnMontagemAmostra.Name = "btnMontagemAmostra";
            this.btnMontagemAmostra.Size = new System.Drawing.Size(159, 96);
            this.btnMontagemAmostra.TabIndex = 6;
            this.btnMontagemAmostra.Text = "Montagem Amostra";
            this.btnMontagemAmostra.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMontagemAmostra.Click += new System.EventHandler(this.BtnMontagemAmostra_Click);
            // 
            // FrmPrincipalAmostra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1291, 659);
            this.Controls.Add(this.rbAmostra);
            this.Controls.Add(this.rbEndereco);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnAmostra);
            this.Controls.Add(this.btnMontagemAmostra);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAmostra2021)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvAmostra2021;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label64;
        private Retaguarda.iTalk.iTalk_Button_2 btnMontagemAmostra;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView DgvMontagem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DgvAmostra;
        private Retaguarda.iTalk.iTalk_Button_2 btnAmostra;
        private Retaguarda.iTalk.iTalk_Button_2 btnEstoque;
        private Retaguarda.iTalk.iTalk_Button_2 btnLimpar;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEndereco;
        private Retaguarda.iTalk.iTalk_Button_2 btnPesquisar;
        private System.Windows.Forms.RadioButton rbAmostra;
    }
}