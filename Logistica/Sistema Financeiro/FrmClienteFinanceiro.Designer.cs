
namespace Logistica.Sistema_Financeiro_Estoque
{
    partial class FrmClienteFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteFinanceiro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btnLimpar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnInserir = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(12, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "Digite para Pesquisar ou Cadastrar novo Cliente";
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.Transparent;
            this.txtClienteId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtClienteId.ForeColor = System.Drawing.Color.Black;
            this.txtClienteId.Location = new System.Drawing.Point(12, 11);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteId.MaxLength = 32767;
            this.txtClienteId.Multiline = false;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = false;
            this.txtClienteId.Size = new System.Drawing.Size(61, 33);
            this.txtClienteId.TabIndex = 39;
            this.txtClienteId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClienteId.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 443);
            this.panel1.TabIndex = 44;
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            this.DgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCliente.Location = new System.Drawing.Point(0, 0);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.RowHeadersWidth = 51;
            this.DgvCliente.RowTemplate.Height = 24;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(1092, 443);
            this.DgvCliente.TabIndex = 0;
            this.DgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellDoubleClick);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(758, 236);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(75, 22);
            this.label44.TabIndex = 90;
            this.label44.Text = "Limpar";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(588, 238);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 22);
            this.label43.TabIndex = 91;
            this.label43.Text = "Deletar";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(417, 236);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(69, 22);
            this.label42.TabIndex = 92;
            this.label42.Text = "Salvar";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(256, 236);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(70, 22);
            this.label41.TabIndex = 93;
            this.label41.Text = "Inserir";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Location = new System.Drawing.Point(742, 159);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 72);
            this.btnLimpar.TabIndex = 86;
            this.btnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Location = new System.Drawing.Point(575, 159);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(103, 72);
            this.btnDeletar.TabIndex = 87;
            this.btnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.Enabled = false;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInserir.Image = global::Logistica.Properties.Resources.icons8_marcador_duplo_48;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.Location = new System.Drawing.Point(240, 159);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(103, 72);
            this.btnInserir.TabIndex = 88;
            this.btnInserir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Location = new System.Drawing.Point(400, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 72);
            this.btnSalvar.TabIndex = 89;
            this.btnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(237, 84);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(618, 38);
            this.txtCliente.TabIndex = 94;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged_1);
            // 
            // FrmClienteFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1092, 751);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtClienteId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimpar;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 btnInserir;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvar;
        private System.Windows.Forms.TextBox txtCliente;
    }
}