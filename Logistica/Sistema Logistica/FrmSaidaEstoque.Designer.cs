
namespace Logistica.Sistema_Logistica
{
    partial class FrmSaidaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaidaEstoque));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new Retaguarda.iTalk.iTalk_Button_2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvSaida = new System.Windows.Forms.DataGridView();
            this.btnInserir = new Retaguarda.iTalk.iTalk_Button_1();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtQtdCaixas = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtUndMedida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtQuantidade = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMaterialSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtSaidaId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtCodigoInfomacao = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.btnLimparInformacao = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnApagar = new Retaguarda.iTalk.iTalk_Button_1();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEstoque = new Retaguarda.iTalk.iTalk_Button_2();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtPesquisarSaida = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvEstoqueObra = new System.Windows.Forms.DataGridView();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProposta = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtFuncionario = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtObra = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtIdObra = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.btnLimparTudo = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnDeletarObra = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnsalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.iTalk_TabControl1 = new Retaguarda.iTalk.iTalk_TabControl();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaida)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstoqueObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.iTalk_TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnInserir);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtQtdCaixas);
            this.tabPage2.Controls.Add(this.txtUndMedida);
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.txtMaterialSaida);
            this.tabPage2.Controls.Add(this.txtSaidaId);
            this.tabPage2.Controls.Add(this.txtCodigoInfomacao);
            this.tabPage2.Controls.Add(this.btnLimparInformacao);
            this.tabPage2.Controls.Add(this.btnApagar);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1037, 714);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Informação da Saida do Material";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(175, 70);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(42, 33);
            this.btnPesquisar.TabIndex = 124;
            this.btnPesquisar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvSaida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 383);
            this.panel1.TabIndex = 123;
            // 
            // DgvSaida
            // 
            this.DgvSaida.AllowUserToAddRows = false;
            this.DgvSaida.AllowUserToDeleteRows = false;
            this.DgvSaida.BackgroundColor = System.Drawing.Color.White;
            this.DgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSaida.Location = new System.Drawing.Point(0, 0);
            this.DgvSaida.Name = "DgvSaida";
            this.DgvSaida.ReadOnly = true;
            this.DgvSaida.RowHeadersWidth = 51;
            this.DgvSaida.RowTemplate.Height = 24;
            this.DgvSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSaida.Size = new System.Drawing.Size(1037, 383);
            this.DgvSaida.TabIndex = 1;
            this.DgvSaida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSaida_CellDoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInserir.Image = global::Logistica.Properties.Resources.icons8_marcador_duplo_48;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(205, 207);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(140, 62);
            this.btnInserir.TabIndex = 122;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(541, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 38);
            this.label23.TabIndex = 96;
            this.label23.Text = "Qtd Saida:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(40, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(182, 38);
            this.label22.TabIndex = 95;
            this.label22.Text = "Und Medida:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(346, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 38);
            this.label20.TabIndex = 94;
            this.label20.Text = "Qtd:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(40, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 38);
            this.label19.TabIndex = 92;
            this.label19.Text = "Material:";
            // 
            // txtQtdCaixas
            // 
            this.txtQtdCaixas.BackColor = System.Drawing.Color.Transparent;
            this.txtQtdCaixas.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtQtdCaixas.ForeColor = System.Drawing.Color.Black;
            this.txtQtdCaixas.Location = new System.Drawing.Point(696, 143);
            this.txtQtdCaixas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdCaixas.MaxLength = 32767;
            this.txtQtdCaixas.Multiline = false;
            this.txtQtdCaixas.Name = "txtQtdCaixas";
            this.txtQtdCaixas.ReadOnly = false;
            this.txtQtdCaixas.Size = new System.Drawing.Size(80, 33);
            this.txtQtdCaixas.TabIndex = 91;
            this.txtQtdCaixas.Text = "0";
            this.txtQtdCaixas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQtdCaixas.UseSystemPasswordChar = false;
            // 
            // txtUndMedida
            // 
            this.txtUndMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtUndMedida.Enabled = false;
            this.txtUndMedida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUndMedida.ForeColor = System.Drawing.Color.Black;
            this.txtUndMedida.Location = new System.Drawing.Point(228, 141);
            this.txtUndMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUndMedida.MaxLength = 32767;
            this.txtUndMedida.Multiline = false;
            this.txtUndMedida.Name = "txtUndMedida";
            this.txtUndMedida.ReadOnly = false;
            this.txtUndMedida.Size = new System.Drawing.Size(107, 33);
            this.txtUndMedida.TabIndex = 85;
            this.txtUndMedida.Text = "m²";
            this.txtUndMedida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUndMedida.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(424, 141);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.Size = new System.Drawing.Size(107, 33);
            this.txtQuantidade.TabIndex = 90;
            this.txtQuantidade.Text = "0,0";
            this.txtQuantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtMaterialSaida
            // 
            this.txtMaterialSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtMaterialSaida.Enabled = false;
            this.txtMaterialSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaterialSaida.ForeColor = System.Drawing.Color.Black;
            this.txtMaterialSaida.Location = new System.Drawing.Point(291, 70);
            this.txtMaterialSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialSaida.MaxLength = 32767;
            this.txtMaterialSaida.Multiline = false;
            this.txtMaterialSaida.Name = "txtMaterialSaida";
            this.txtMaterialSaida.ReadOnly = false;
            this.txtMaterialSaida.Size = new System.Drawing.Size(477, 33);
            this.txtMaterialSaida.TabIndex = 87;
            this.txtMaterialSaida.Text = "Nome do Item ";
            this.txtMaterialSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterialSaida.UseSystemPasswordChar = false;
            // 
            // txtSaidaId
            // 
            this.txtSaidaId.BackColor = System.Drawing.Color.Transparent;
            this.txtSaidaId.Enabled = false;
            this.txtSaidaId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSaidaId.ForeColor = System.Drawing.Color.Black;
            this.txtSaidaId.Location = new System.Drawing.Point(3, 2);
            this.txtSaidaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaidaId.MaxLength = 32767;
            this.txtSaidaId.Multiline = false;
            this.txtSaidaId.Name = "txtSaidaId";
            this.txtSaidaId.ReadOnly = false;
            this.txtSaidaId.Size = new System.Drawing.Size(55, 33);
            this.txtSaidaId.TabIndex = 86;
            this.txtSaidaId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSaidaId.UseSystemPasswordChar = false;
            // 
            // txtCodigoInfomacao
            // 
            this.txtCodigoInfomacao.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoInfomacao.Enabled = false;
            this.txtCodigoInfomacao.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCodigoInfomacao.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoInfomacao.Location = new System.Drawing.Point(230, 70);
            this.txtCodigoInfomacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoInfomacao.MaxLength = 32767;
            this.txtCodigoInfomacao.Multiline = false;
            this.txtCodigoInfomacao.Name = "txtCodigoInfomacao";
            this.txtCodigoInfomacao.ReadOnly = false;
            this.txtCodigoInfomacao.Size = new System.Drawing.Size(55, 33);
            this.txtCodigoInfomacao.TabIndex = 86;
            this.txtCodigoInfomacao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoInfomacao.UseSystemPasswordChar = false;
            // 
            // btnLimparInformacao
            // 
            this.btnLimparInformacao.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparInformacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimparInformacao.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.btnLimparInformacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparInformacao.Location = new System.Drawing.Point(577, 207);
            this.btnLimparInformacao.Name = "btnLimparInformacao";
            this.btnLimparInformacao.Size = new System.Drawing.Size(140, 62);
            this.btnLimparInformacao.TabIndex = 97;
            this.btnLimparInformacao.Text = "Limpar";
            this.btnLimparInformacao.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnLimparInformacao.Click += new System.EventHandler(this.BtnLimparInformacao_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnApagar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(390, 207);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(140, 62);
            this.btnApagar.TabIndex = 98;
            this.btnApagar.Text = "Deletar";
            this.btnApagar.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1045, 752);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Saida de      Material";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1045, 752);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage3.Controls.Add(this.btnEstoque);
            this.tabPage3.Controls.Add(this.btnGerarId);
            this.tabPage3.Controls.Add(this.txtPesquisarSaida);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dtpDataSaida);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtProposta);
            this.tabPage3.Controls.Add(this.txtFuncionario);
            this.tabPage3.Controls.Add(this.txtObra);
            this.tabPage3.Controls.Add(this.txtIdObra);
            this.tabPage3.Controls.Add(this.btnLimparTudo);
            this.tabPage3.Controls.Add(this.btnDeletarObra);
            this.tabPage3.Controls.Add(this.btnsalvar);
            this.tabPage3.Controls.Add(this.pictureBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1037, 714);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Informações da Obra";
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = null;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(827, 172);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(120, 65);
            this.btnEstoque.TabIndex = 128;
            this.btnEstoque.Text = "Verificar Estoque";
            this.btnEstoque.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(804, 13);
            this.btnGerarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(118, 36);
            this.btnGerarId.TabIndex = 127;
            this.btnGerarId.Text = "GERAR ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.BtnCriarProposta_Click);
            // 
            // txtPesquisarSaida
            // 
            this.txtPesquisarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarSaida.Location = new System.Drawing.Point(532, 172);
            this.txtPesquisarSaida.Name = "txtPesquisarSaida";
            this.txtPesquisarSaida.Size = new System.Drawing.Size(289, 30);
            this.txtPesquisarSaida.TabIndex = 126;
            this.txtPesquisarSaida.Text = "Digite para Pesquisar:";
            this.txtPesquisarSaida.Click += new System.EventHandler(this.TxtPesquisarSaida_Click);
            this.txtPesquisarSaida.TextChanged += new System.EventHandler(this.TxtPesquisarSaida_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvEstoqueObra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 430);
            this.panel2.TabIndex = 124;
            // 
            // DgvEstoqueObra
            // 
            this.DgvEstoqueObra.AllowUserToAddRows = false;
            this.DgvEstoqueObra.AllowUserToDeleteRows = false;
            this.DgvEstoqueObra.BackgroundColor = System.Drawing.Color.White;
            this.DgvEstoqueObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstoqueObra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEstoqueObra.Location = new System.Drawing.Point(0, 0);
            this.DgvEstoqueObra.Name = "DgvEstoqueObra";
            this.DgvEstoqueObra.ReadOnly = true;
            this.DgvEstoqueObra.RowHeadersWidth = 51;
            this.DgvEstoqueObra.RowTemplate.Height = 24;
            this.DgvEstoqueObra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstoqueObra.Size = new System.Drawing.Size(1031, 430);
            this.DgvEstoqueObra.TabIndex = 0;
            this.DgvEstoqueObra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstoqueObra_CellDoubleClick);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSaida.Location = new System.Drawing.Point(474, 17);
            this.dtpDataSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(140, 31);
            this.dtpDataSaida.TabIndex = 117;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(307, 13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(161, 38);
            this.label45.TabIndex = 116;
            this.label45.Text = "Data Saida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 38);
            this.label3.TabIndex = 114;
            this.label3.Text = "Funcionario na Obra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 114;
            this.label1.Text = "Obra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 115;
            this.label2.Text = "Proposta:";
            // 
            // txtProposta
            // 
            this.txtProposta.BackColor = System.Drawing.Color.Transparent;
            this.txtProposta.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtProposta.ForeColor = System.Drawing.Color.Black;
            this.txtProposta.Location = new System.Drawing.Point(141, 13);
            this.txtProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProposta.MaxLength = 32767;
            this.txtProposta.Multiline = false;
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.ReadOnly = false;
            this.txtProposta.Size = new System.Drawing.Size(156, 33);
            this.txtProposta.TabIndex = 112;
            this.txtProposta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProposta.UseSystemPasswordChar = false;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.txtFuncionario.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFuncionario.ForeColor = System.Drawing.Color.Black;
            this.txtFuncionario.Location = new System.Drawing.Point(323, 115);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFuncionario.MaxLength = 32767;
            this.txtFuncionario.Multiline = false;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = false;
            this.txtFuncionario.Size = new System.Drawing.Size(303, 33);
            this.txtFuncionario.TabIndex = 113;
            this.txtFuncionario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFuncionario.UseSystemPasswordChar = false;
            // 
            // txtObra
            // 
            this.txtObra.BackColor = System.Drawing.Color.Transparent;
            this.txtObra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtObra.ForeColor = System.Drawing.Color.Black;
            this.txtObra.Location = new System.Drawing.Point(105, 68);
            this.txtObra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObra.MaxLength = 32767;
            this.txtObra.Multiline = false;
            this.txtObra.Name = "txtObra";
            this.txtObra.ReadOnly = false;
            this.txtObra.Size = new System.Drawing.Size(627, 33);
            this.txtObra.TabIndex = 113;
            this.txtObra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObra.UseSystemPasswordChar = false;
            // 
            // txtIdObra
            // 
            this.txtIdObra.BackColor = System.Drawing.Color.Transparent;
            this.txtIdObra.Enabled = false;
            this.txtIdObra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtIdObra.ForeColor = System.Drawing.Color.Black;
            this.txtIdObra.Location = new System.Drawing.Point(743, 16);
            this.txtIdObra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdObra.MaxLength = 32767;
            this.txtIdObra.Multiline = false;
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.ReadOnly = false;
            this.txtIdObra.Size = new System.Drawing.Size(55, 33);
            this.txtIdObra.TabIndex = 108;
            this.txtIdObra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdObra.UseSystemPasswordChar = false;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparTudo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimparTudo.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.btnLimparTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparTudo.Location = new System.Drawing.Point(357, 172);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(130, 72);
            this.btnLimparTudo.TabIndex = 109;
            this.btnLimparTudo.Text = "Limpar";
            this.btnLimparTudo.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnLimparTudo.Click += new System.EventHandler(this.BtnLimparTudo_Click);
            // 
            // btnDeletarObra
            // 
            this.btnDeletarObra.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarObra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletarObra.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletarObra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarObra.Location = new System.Drawing.Point(176, 172);
            this.btnDeletarObra.Name = "btnDeletarObra";
            this.btnDeletarObra.Size = new System.Drawing.Size(130, 72);
            this.btnDeletarObra.TabIndex = 110;
            this.btnDeletarObra.Text = "Deletar";
            this.btnDeletarObra.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnDeletarObra.Click += new System.EventHandler(this.BtnDeletarObra_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(19, 172);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 72);
            this.btnsalvar.TabIndex = 111;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnsalvar.Click += new System.EventHandler(this.Btnsalvar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox6.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox6.Location = new System.Drawing.Point(847, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 105;
            this.pictureBox6.TabStop = false;
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
            this.iTalk_TabControl1.Size = new System.Drawing.Size(1188, 760);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 2;
            // 
            // FrmSaidaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 760);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSaidaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material que foi para Obra ";
            this.Load += new System.EventHandler(this.FrmSaidaEstoque_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaida)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstoqueObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.iTalk_TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private Retaguarda.iTalk.iTalk_Button_1 btnInserir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtQtdCaixas;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtUndMedida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtQuantidade;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMaterialSaida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtSaidaId;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtCodigoInfomacao;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimparInformacao;
        private Retaguarda.iTalk.iTalk_Button_1 btnApagar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private Retaguarda.iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtProposta;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtObra;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtIdObra;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimparTudo;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletarObra;
        private Retaguarda.iTalk.iTalk_Button_1 btnsalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvSaida;
        private System.Windows.Forms.TextBox txtPesquisarSaida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvEstoqueObra;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label label45;
        private Retaguarda.iTalk.iTalk_Button_2 btnPesquisar;
        private System.Windows.Forms.Button btnGerarId;
        private Retaguarda.iTalk.iTalk_Button_2 btnEstoque;
        private System.Windows.Forms.Label label3;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtFuncionario;
    }
}