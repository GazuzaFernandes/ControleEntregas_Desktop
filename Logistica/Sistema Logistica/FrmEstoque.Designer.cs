
namespace Logistica.Sistema_Logistica
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.txtPesquisaMaterial = new System.Windows.Forms.TextBox();
            this.DgvMaterial = new System.Windows.Forms.DataGridView();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.txtCodigoMaterial = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtSaidaQuantidadeCaixa = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtEstoqueSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtEstoqueAtualSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtCalcularSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMedidaSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMadeiraSaida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnLimparMaterial = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSelecionar = new Retaguarda.iTalk.iTalk_Button_1();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLimparTudo = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSalvarMaterial = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSalvarData = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.btnDeletarData = new Retaguarda.iTalk.iTalk_Button_1();
            this.txtMaterialId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.btnDeletarMaterial = new Retaguarda.iTalk.iTalk_Button_1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.txtDataId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.txtTotal = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtTotalCaixas = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtQuantidadeCaixa = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtSomaEntrada = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtEntrada = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtUnidadeMedida = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtDevolucao = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMaterial = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtFabrica = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iTalk_TabControl1 = new Retaguarda.iTalk.iTalk_TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.iTalk_TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisaMaterial
            // 
            this.txtPesquisaMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMaterial.Location = new System.Drawing.Point(331, 194);
            this.txtPesquisaMaterial.Name = "txtPesquisaMaterial";
            this.txtPesquisaMaterial.Size = new System.Drawing.Size(289, 30);
            this.txtPesquisaMaterial.TabIndex = 118;
            this.txtPesquisaMaterial.Text = "Digite para Pesquisar:";
            this.txtPesquisaMaterial.Click += new System.EventHandler(this.TxtPesquisaMaterial_Click);
            this.txtPesquisaMaterial.TextChanged += new System.EventHandler(this.TxtPesquisaMaterial_TextChanged);
            // 
            // DgvMaterial
            // 
            this.DgvMaterial.AllowUserToAddRows = false;
            this.DgvMaterial.AllowUserToDeleteRows = false;
            this.DgvMaterial.BackgroundColor = System.Drawing.Color.White;
            this.DgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.DgvMaterial.Name = "DgvMaterial";
            this.DgvMaterial.ReadOnly = true;
            this.DgvMaterial.RowHeadersWidth = 51;
            this.DgvMaterial.RowTemplate.Height = 24;
            this.DgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMaterial.Size = new System.Drawing.Size(1356, 449);
            this.DgvMaterial.TabIndex = 0;
            this.DgvMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterial_CellDoubleClick);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(193, 242);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(75, 22);
            this.label58.TabIndex = 115;
            this.label58.Text = "Limpar";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(40, 242);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(70, 22);
            this.label59.TabIndex = 116;
            this.label59.Text = "Inserir";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage4.Controls.Add(this.txtPesquisaMaterial);
            this.tabPage4.Controls.Add(this.label58);
            this.tabPage4.Controls.Add(this.label59);
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.label55);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.label53);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.label64);
            this.tabPage4.Controls.Add(this.label65);
            this.tabPage4.Controls.Add(this.txtCodigoMaterial);
            this.tabPage4.Controls.Add(this.txtSaidaQuantidadeCaixa);
            this.tabPage4.Controls.Add(this.txtEstoqueSaida);
            this.tabPage4.Controls.Add(this.txtEstoqueAtualSaida);
            this.tabPage4.Controls.Add(this.txtCalcularSaida);
            this.tabPage4.Controls.Add(this.txtMedidaSaida);
            this.tabPage4.Controls.Add(this.txtMadeiraSaida);
            this.tabPage4.Controls.Add(this.pictureBox7);
            this.tabPage4.Controls.Add(this.btnLimparMaterial);
            this.tabPage4.Controls.Add(this.btnSelecionar);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1362, 728);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Saida do Material";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DgvMaterial);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1356, 449);
            this.panel6.TabIndex = 107;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(656, 95);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(235, 38);
            this.label55.TabIndex = 106;
            this.label55.Text = "Qtd por Produto:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(852, 186);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(0, 38);
            this.label54.TabIndex = 106;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(17, 93);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(149, 38);
            this.label53.TabIndex = 106;
            this.label53.Text = "Qtd Saida.";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(793, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(182, 38);
            this.label52.TabIndex = 106;
            this.label52.Text = "Und Medida.";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(434, 95);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(85, 38);
            this.label64.TabIndex = 106;
            this.label64.Text = "Total:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(17, 19);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(129, 38);
            this.label65.TabIndex = 105;
            this.label65.Text = "Material:";
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoMaterial.Enabled = false;
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCodigoMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoMaterial.Location = new System.Drawing.Point(152, 22);
            this.txtCodigoMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoMaterial.MaxLength = 32767;
            this.txtCodigoMaterial.Multiline = false;
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.ReadOnly = false;
            this.txtCodigoMaterial.Size = new System.Drawing.Size(55, 33);
            this.txtCodigoMaterial.TabIndex = 104;
            this.txtCodigoMaterial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoMaterial.UseSystemPasswordChar = false;
            // 
            // txtSaidaQuantidadeCaixa
            // 
            this.txtSaidaQuantidadeCaixa.BackColor = System.Drawing.Color.Transparent;
            this.txtSaidaQuantidadeCaixa.Enabled = false;
            this.txtSaidaQuantidadeCaixa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSaidaQuantidadeCaixa.ForeColor = System.Drawing.Color.Black;
            this.txtSaidaQuantidadeCaixa.Location = new System.Drawing.Point(897, 100);
            this.txtSaidaQuantidadeCaixa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaidaQuantidadeCaixa.MaxLength = 32767;
            this.txtSaidaQuantidadeCaixa.Multiline = false;
            this.txtSaidaQuantidadeCaixa.Name = "txtSaidaQuantidadeCaixa";
            this.txtSaidaQuantidadeCaixa.ReadOnly = false;
            this.txtSaidaQuantidadeCaixa.Size = new System.Drawing.Size(89, 33);
            this.txtSaidaQuantidadeCaixa.TabIndex = 101;
            this.txtSaidaQuantidadeCaixa.Text = "0";
            this.txtSaidaQuantidadeCaixa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSaidaQuantidadeCaixa.UseSystemPasswordChar = false;
            // 
            // txtEstoqueSaida
            // 
            this.txtEstoqueSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtEstoqueSaida.Enabled = false;
            this.txtEstoqueSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEstoqueSaida.ForeColor = System.Drawing.Color.Black;
            this.txtEstoqueSaida.Location = new System.Drawing.Point(525, 98);
            this.txtEstoqueSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoqueSaida.MaxLength = 32767;
            this.txtEstoqueSaida.Multiline = false;
            this.txtEstoqueSaida.Name = "txtEstoqueSaida";
            this.txtEstoqueSaida.ReadOnly = false;
            this.txtEstoqueSaida.Size = new System.Drawing.Size(125, 33);
            this.txtEstoqueSaida.TabIndex = 101;
            this.txtEstoqueSaida.Text = "0";
            this.txtEstoqueSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstoqueSaida.UseSystemPasswordChar = false;
            // 
            // txtEstoqueAtualSaida
            // 
            this.txtEstoqueAtualSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtEstoqueAtualSaida.Enabled = false;
            this.txtEstoqueAtualSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEstoqueAtualSaida.ForeColor = System.Drawing.Color.Black;
            this.txtEstoqueAtualSaida.Location = new System.Drawing.Point(295, 98);
            this.txtEstoqueAtualSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoqueAtualSaida.MaxLength = 32767;
            this.txtEstoqueAtualSaida.Multiline = false;
            this.txtEstoqueAtualSaida.Name = "txtEstoqueAtualSaida";
            this.txtEstoqueAtualSaida.ReadOnly = false;
            this.txtEstoqueAtualSaida.Size = new System.Drawing.Size(126, 33);
            this.txtEstoqueAtualSaida.TabIndex = 100;
            this.txtEstoqueAtualSaida.Text = "0";
            this.txtEstoqueAtualSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstoqueAtualSaida.UseSystemPasswordChar = false;
            this.txtEstoqueAtualSaida.TextChanged += new System.EventHandler(this.TxtSaida2_TextChanged);
            // 
            // txtCalcularSaida
            // 
            this.txtCalcularSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtCalcularSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCalcularSaida.ForeColor = System.Drawing.Color.Black;
            this.txtCalcularSaida.Location = new System.Drawing.Point(172, 98);
            this.txtCalcularSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalcularSaida.MaxLength = 32767;
            this.txtCalcularSaida.Multiline = false;
            this.txtCalcularSaida.Name = "txtCalcularSaida";
            this.txtCalcularSaida.ReadOnly = false;
            this.txtCalcularSaida.Size = new System.Drawing.Size(117, 33);
            this.txtCalcularSaida.TabIndex = 99;
            this.txtCalcularSaida.Text = "0";
            this.txtCalcularSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalcularSaida.UseSystemPasswordChar = false;
            this.txtCalcularSaida.TextChanged += new System.EventHandler(this.TxtSaida_TextChanged);
            // 
            // txtMedidaSaida
            // 
            this.txtMedidaSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtMedidaSaida.Enabled = false;
            this.txtMedidaSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMedidaSaida.ForeColor = System.Drawing.Color.Black;
            this.txtMedidaSaida.Location = new System.Drawing.Point(981, 22);
            this.txtMedidaSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedidaSaida.MaxLength = 32767;
            this.txtMedidaSaida.Multiline = false;
            this.txtMedidaSaida.Name = "txtMedidaSaida";
            this.txtMedidaSaida.ReadOnly = false;
            this.txtMedidaSaida.Size = new System.Drawing.Size(113, 33);
            this.txtMedidaSaida.TabIndex = 98;
            this.txtMedidaSaida.Text = "Und Medida";
            this.txtMedidaSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMedidaSaida.UseSystemPasswordChar = false;
            // 
            // txtMadeiraSaida
            // 
            this.txtMadeiraSaida.BackColor = System.Drawing.Color.Transparent;
            this.txtMadeiraSaida.Enabled = false;
            this.txtMadeiraSaida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMadeiraSaida.ForeColor = System.Drawing.Color.Black;
            this.txtMadeiraSaida.Location = new System.Drawing.Point(224, 22);
            this.txtMadeiraSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMadeiraSaida.MaxLength = 32767;
            this.txtMadeiraSaida.Multiline = false;
            this.txtMadeiraSaida.Name = "txtMadeiraSaida";
            this.txtMadeiraSaida.ReadOnly = false;
            this.txtMadeiraSaida.Size = new System.Drawing.Size(563, 33);
            this.txtMadeiraSaida.TabIndex = 102;
            this.txtMadeiraSaida.Text = "Material";
            this.txtMadeiraSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMadeiraSaida.UseSystemPasswordChar = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox7.Location = new System.Drawing.Point(941, 149);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(153, 110);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 117;
            this.pictureBox7.TabStop = false;
            // 
            // btnLimparMaterial
            // 
            this.btnLimparMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparMaterial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimparMaterial.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.btnLimparMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparMaterial.Location = new System.Drawing.Point(180, 163);
            this.btnLimparMaterial.Name = "btnLimparMaterial";
            this.btnLimparMaterial.Size = new System.Drawing.Size(103, 72);
            this.btnLimparMaterial.TabIndex = 113;
            this.btnLimparMaterial.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimparMaterial.Click += new System.EventHandler(this.BtnLimparMaterial_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSelecionar.Image = global::Logistica.Properties.Resources.icons8_marcador_duplo_48;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelecionar.Location = new System.Drawing.Point(24, 163);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(103, 72);
            this.btnSelecionar.TabIndex = 114;
            this.btnSelecionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1370, 766);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage3.Controls.Add(this.btnLimparTudo);
            this.tabPage3.Controls.Add(this.btnSalvarMaterial);
            this.tabPage3.Controls.Add(this.btnSalvarData);
            this.tabPage3.Controls.Add(this.btnGerarId);
            this.tabPage3.Controls.Add(this.btnDeletarData);
            this.tabPage3.Controls.Add(this.txtMaterialId);
            this.tabPage3.Controls.Add(this.btnDeletarMaterial);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.dtpData);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.pictureBox6);
            this.tabPage3.Controls.Add(this.label46);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.txtTotal);
            this.tabPage3.Controls.Add(this.txtTotalCaixas);
            this.tabPage3.Controls.Add(this.txtQuantidadeCaixa);
            this.tabPage3.Controls.Add(this.txtSomaEntrada);
            this.tabPage3.Controls.Add(this.txtEntrada);
            this.tabPage3.Controls.Add(this.txtUnidadeMedida);
            this.tabPage3.Controls.Add(this.txtDevolucao);
            this.tabPage3.Controls.Add(this.txtMaterial);
            this.tabPage3.Controls.Add(this.txtFabrica);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1362, 728);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cadastro de Material";
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparTudo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.btnLimparTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparTudo.Location = new System.Drawing.Point(783, 588);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(223, 66);
            this.btnLimparTudo.TabIndex = 116;
            this.btnLimparTudo.Text = "Limpar";
            this.btnLimparTudo.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnLimparTudo.Click += new System.EventHandler(this.BtnLimparTudo_Click);
            // 
            // btnSalvarMaterial
            // 
            this.btnSalvarMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarMaterial.Enabled = false;
            this.btnSalvarMaterial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMaterial.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnSalvarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarMaterial.Location = new System.Drawing.Point(1021, 380);
            this.btnSalvarMaterial.Name = "btnSalvarMaterial";
            this.btnSalvarMaterial.Size = new System.Drawing.Size(223, 71);
            this.btnSalvarMaterial.TabIndex = 110;
            this.btnSalvarMaterial.Text = "Salvar Tudo";
            this.btnSalvarMaterial.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnSalvarMaterial.Click += new System.EventHandler(this.BtnSalvarMaterial_Click);
            // 
            // btnSalvarData
            // 
            this.btnSalvarData.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarData.Enabled = false;
            this.btnSalvarData.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarData.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnSalvarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarData.Location = new System.Drawing.Point(783, 380);
            this.btnSalvarData.Name = "btnSalvarData";
            this.btnSalvarData.Size = new System.Drawing.Size(223, 71);
            this.btnSalvarData.TabIndex = 109;
            this.btnSalvarData.Text = "Salvar Datas";
            this.btnSalvarData.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnSalvarData.Click += new System.EventHandler(this.BtnSalvarData_Click);
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(1041, 35);
            this.btnGerarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(118, 34);
            this.btnGerarId.TabIndex = 25;
            this.btnGerarId.Text = "GERAR ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.BtnGerarMaterial_Click);
            // 
            // btnDeletarData
            // 
            this.btnDeletarData.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarData.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarData.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarData.Location = new System.Drawing.Point(783, 487);
            this.btnDeletarData.Name = "btnDeletarData";
            this.btnDeletarData.Size = new System.Drawing.Size(223, 66);
            this.btnDeletarData.TabIndex = 112;
            this.btnDeletarData.Text = "Deletar Data";
            this.btnDeletarData.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnDeletarData.Click += new System.EventHandler(this.BtnDeletarData_Click);
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.BackColor = System.Drawing.Color.Transparent;
            this.txtMaterialId.Enabled = false;
            this.txtMaterialId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaterialId.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaterialId.Location = new System.Drawing.Point(938, 35);
            this.txtMaterialId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialId.MaxLength = 32767;
            this.txtMaterialId.Multiline = false;
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.ReadOnly = false;
            this.txtMaterialId.Size = new System.Drawing.Size(97, 33);
            this.txtMaterialId.TabIndex = 29;
            this.txtMaterialId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterialId.UseSystemPasswordChar = false;
            // 
            // btnDeletarMaterial
            // 
            this.btnDeletarMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarMaterial.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarMaterial.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarMaterial.Location = new System.Drawing.Point(1021, 487);
            this.btnDeletarMaterial.Name = "btnDeletarMaterial";
            this.btnDeletarMaterial.Size = new System.Drawing.Size(223, 66);
            this.btnDeletarMaterial.TabIndex = 111;
            this.btnDeletarMaterial.Text = "Deletar Tudo";
            this.btnDeletarMaterial.TextAlignment = System.Drawing.StringAlignment.Far;
            this.btnDeletarMaterial.Click += new System.EventHandler(this.BtnDeletarMaterial_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtDataId);
            this.panel2.Location = new System.Drawing.Point(26, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 404);
            this.panel2.TabIndex = 108;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 348);
            this.panel3.TabIndex = 53;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 51;
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(751, 348);
            this.DgvData.TabIndex = 0;
            this.DgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellDoubleClick);
            // 
            // txtDataId
            // 
            this.txtDataId.BackColor = System.Drawing.Color.Transparent;
            this.txtDataId.Enabled = false;
            this.txtDataId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDataId.ForeColor = System.Drawing.Color.Black;
            this.txtDataId.Location = new System.Drawing.Point(3, 2);
            this.txtDataId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataId.MaxLength = 32767;
            this.txtDataId.Multiline = false;
            this.txtDataId.Name = "txtDataId";
            this.txtDataId.ReadOnly = false;
            this.txtDataId.Size = new System.Drawing.Size(47, 33);
            this.txtDataId.TabIndex = 26;
            this.txtDataId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataId.UseSystemPasswordChar = false;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(739, 39);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(140, 31);
            this.dtpData.TabIndex = 107;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(493, 35);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(222, 38);
            this.label45.TabIndex = 106;
            this.label45.Text = "Data do Pedido:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox6.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox6.Location = new System.Drawing.Point(1021, 577);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(169, 135);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 105;
            this.pictureBox6.TabStop = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(442, 182);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 38);
            this.label46.TabIndex = 101;
            this.label46.Text = "Total:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(41, 182);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(122, 38);
            this.label47.TabIndex = 100;
            this.label47.Text = "Entrada:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(968, 109);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(104, 38);
            this.label56.TabIndex = 99;
            this.label56.Text = "Caixas:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(637, 107);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(217, 38);
            this.label51.TabIndex = 99;
            this.label51.Text = "Qtd por Pacote:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(697, 182);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(182, 38);
            this.label48.TabIndex = 99;
            this.label48.Text = "Und Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 98;
            this.label1.Text = "Devolução Obra:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(23, 107);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(129, 38);
            this.label49.TabIndex = 98;
            this.label49.Text = "Material:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(19, 35);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(107, 38);
            this.label50.TabIndex = 97;
            this.label50.Text = "Fabrica";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(533, 185);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.Size = new System.Drawing.Size(132, 33);
            this.txtTotal.TabIndex = 94;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtTotalCaixas
            // 
            this.txtTotalCaixas.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalCaixas.Enabled = false;
            this.txtTotalCaixas.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTotalCaixas.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCaixas.Location = new System.Drawing.Point(1078, 112);
            this.txtTotalCaixas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalCaixas.MaxLength = 32767;
            this.txtTotalCaixas.Multiline = false;
            this.txtTotalCaixas.Name = "txtTotalCaixas";
            this.txtTotalCaixas.ReadOnly = false;
            this.txtTotalCaixas.Size = new System.Drawing.Size(91, 33);
            this.txtTotalCaixas.TabIndex = 91;
            this.txtTotalCaixas.Text = "0";
            this.txtTotalCaixas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalCaixas.UseSystemPasswordChar = false;
            // 
            // txtQuantidadeCaixa
            // 
            this.txtQuantidadeCaixa.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidadeCaixa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtQuantidadeCaixa.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidadeCaixa.Location = new System.Drawing.Point(860, 112);
            this.txtQuantidadeCaixa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeCaixa.MaxLength = 32767;
            this.txtQuantidadeCaixa.Multiline = false;
            this.txtQuantidadeCaixa.Name = "txtQuantidadeCaixa";
            this.txtQuantidadeCaixa.ReadOnly = false;
            this.txtQuantidadeCaixa.Size = new System.Drawing.Size(102, 33);
            this.txtQuantidadeCaixa.TabIndex = 91;
            this.txtQuantidadeCaixa.Text = "1";
            this.txtQuantidadeCaixa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidadeCaixa.UseSystemPasswordChar = false;
            this.txtQuantidadeCaixa.TextChanged += new System.EventHandler(this.TxtQuantidadeCaixa_TextChanged);
            // 
            // txtSomaEntrada
            // 
            this.txtSomaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaEntrada.Enabled = false;
            this.txtSomaEntrada.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSomaEntrada.ForeColor = System.Drawing.Color.Black;
            this.txtSomaEntrada.Location = new System.Drawing.Point(297, 185);
            this.txtSomaEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSomaEntrada.MaxLength = 32767;
            this.txtSomaEntrada.Multiline = false;
            this.txtSomaEntrada.Name = "txtSomaEntrada";
            this.txtSomaEntrada.ReadOnly = false;
            this.txtSomaEntrada.Size = new System.Drawing.Size(132, 33);
            this.txtSomaEntrada.TabIndex = 92;
            this.txtSomaEntrada.Text = "0";
            this.txtSomaEntrada.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSomaEntrada.UseSystemPasswordChar = false;
            this.txtSomaEntrada.TextChanged += new System.EventHandler(this.TxtSomaEntrada_TextChanged);
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.Transparent;
            this.txtEntrada.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEntrada.ForeColor = System.Drawing.Color.Black;
            this.txtEntrada.Location = new System.Drawing.Point(169, 185);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEntrada.MaxLength = 32767;
            this.txtEntrada.Multiline = false;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ReadOnly = false;
            this.txtEntrada.Size = new System.Drawing.Size(122, 33);
            this.txtEntrada.TabIndex = 92;
            this.txtEntrada.Text = "0";
            this.txtEntrada.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEntrada.UseSystemPasswordChar = false;
            this.txtEntrada.TextChanged += new System.EventHandler(this.TxtEntrada_TextChanged);
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUnidadeMedida.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(888, 187);
            this.txtUnidadeMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidadeMedida.MaxLength = 32767;
            this.txtUnidadeMedida.Multiline = false;
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.ReadOnly = false;
            this.txtUnidadeMedida.Size = new System.Drawing.Size(83, 33);
            this.txtUnidadeMedida.TabIndex = 91;
            this.txtUnidadeMedida.Text = "kg";
            this.txtUnidadeMedida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUnidadeMedida.UseSystemPasswordChar = false;
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.BackColor = System.Drawing.Color.Transparent;
            this.txtDevolucao.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDevolucao.ForeColor = System.Drawing.Color.Black;
            this.txtDevolucao.Location = new System.Drawing.Point(279, 249);
            this.txtDevolucao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDevolucao.MaxLength = 32767;
            this.txtDevolucao.Multiline = false;
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.ReadOnly = false;
            this.txtDevolucao.Size = new System.Drawing.Size(473, 33);
            this.txtDevolucao.TabIndex = 96;
            this.txtDevolucao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDevolucao.UseSystemPasswordChar = false;
            // 
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.Color.Transparent;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtMaterial.Location = new System.Drawing.Point(158, 110);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterial.MaxLength = 32767;
            this.txtMaterial.Multiline = false;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = false;
            this.txtMaterial.Size = new System.Drawing.Size(473, 33);
            this.txtMaterial.TabIndex = 96;
            this.txtMaterial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterial.UseSystemPasswordChar = false;
            // 
            // txtFabrica
            // 
            this.txtFabrica.BackColor = System.Drawing.Color.Transparent;
            this.txtFabrica.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFabrica.ForeColor = System.Drawing.Color.Black;
            this.txtFabrica.Location = new System.Drawing.Point(132, 38);
            this.txtFabrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFabrica.MaxLength = 32767;
            this.txtFabrica.Multiline = false;
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.ReadOnly = false;
            this.txtFabrica.Size = new System.Drawing.Size(344, 33);
            this.txtFabrica.TabIndex = 95;
            this.txtFabrica.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFabrica.UseSystemPasswordChar = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1370, 766);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Saida de      Material";
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
            this.iTalk_TabControl1.Size = new System.Drawing.Size(1513, 774);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 1;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 774);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaMaterial;
        private System.Windows.Forms.DataGridView DgvMaterial;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimparMaterial;
        private Retaguarda.iTalk.iTalk_Button_1 btnSelecionar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtCodigoMaterial;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtSaidaQuantidadeCaixa;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtEstoqueSaida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtEstoqueAtualSaida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtCalcularSaida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMedidaSaida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMadeiraSaida;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimparTudo;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvarMaterial;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvarData;
        private System.Windows.Forms.Button btnGerarId;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletarData;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMaterialId;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletarMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvData;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtDataId;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtTotal;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtTotalCaixas;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtQuantidadeCaixa;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtSomaEntrada;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtEntrada;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtUnidadeMedida;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMaterial;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtFabrica;
        private System.Windows.Forms.TabPage tabPage1;
        private Retaguarda.iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtDevolucao;
    }
}