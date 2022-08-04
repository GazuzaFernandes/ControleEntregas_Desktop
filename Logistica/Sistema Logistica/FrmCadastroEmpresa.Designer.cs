
namespace LogisticaEntregas
{
    partial class FrmCadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEmpresa));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvCadastroEmpresa = new System.Windows.Forms.DataGridView();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLimpar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnInserir = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.TxtEmpresa = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtCodigoId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 38);
            this.label2.TabIndex = 38;
            this.label2.Text = "Informe: Empresa, Construtora, Cliente.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvCadastroEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 392);
            this.panel1.TabIndex = 42;
            // 
            // DgvCadastroEmpresa
            // 
            this.DgvCadastroEmpresa.AllowUserToAddRows = false;
            this.DgvCadastroEmpresa.AllowUserToDeleteRows = false;
            this.DgvCadastroEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.DgvCadastroEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCadastroEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCadastroEmpresa.Location = new System.Drawing.Point(0, 0);
            this.DgvCadastroEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvCadastroEmpresa.Name = "DgvCadastroEmpresa";
            this.DgvCadastroEmpresa.ReadOnly = true;
            this.DgvCadastroEmpresa.RowHeadersWidth = 51;
            this.DgvCadastroEmpresa.RowTemplate.Height = 29;
            this.DgvCadastroEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCadastroEmpresa.Size = new System.Drawing.Size(1005, 392);
            this.DgvCadastroEmpresa.TabIndex = 0;
            this.DgvCadastroEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroEmpresa_CellDoubleClick);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(689, 167);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(75, 22);
            this.label44.TabIndex = 78;
            this.label44.Text = "Limpar";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(515, 167);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 22);
            this.label43.TabIndex = 79;
            this.label43.Text = "Deletar";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(344, 167);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(69, 22);
            this.label42.TabIndex = 80;
            this.label42.Text = "Salvar";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(192, 167);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(70, 22);
            this.label41.TabIndex = 81;
            this.label41.Text = "Inserir";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(832, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_48;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimpar.Location = new System.Drawing.Point(667, 96);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(119, 68);
            this.BtnLimpar.TabIndex = 47;
            this.BtnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeletar.Image = global::Logistica.Properties.Resources.icons8_wastebasket_48;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(494, 96);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(119, 68);
            this.BtnDeletar.TabIndex = 48;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnInserir
            // 
            this.BtnInserir.BackColor = System.Drawing.Color.Transparent;
            this.BtnInserir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInserir.Image = global::Logistica.Properties.Resources.icons8_marcador_duplo_48;
            this.BtnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnInserir.Location = new System.Drawing.Point(168, 96);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(119, 68);
            this.BtnInserir.TabIndex = 49;
            this.BtnInserir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_48;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(319, 96);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(119, 68);
            this.BtnSalvar.TabIndex = 50;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.TxtEmpresa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtEmpresa.ForeColor = System.Drawing.Color.Black;
            this.TxtEmpresa.Location = new System.Drawing.Point(168, 47);
            this.TxtEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmpresa.MaxLength = 32767;
            this.TxtEmpresa.Multiline = false;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.ReadOnly = false;
            this.TxtEmpresa.Size = new System.Drawing.Size(618, 33);
            this.TxtEmpresa.TabIndex = 37;
            this.TxtEmpresa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmpresa.UseSystemPasswordChar = false;
            this.TxtEmpresa.TextChanged += new System.EventHandler(this.TxtEmpresa_TextChanged);
            // 
            // TxtCodigoId
            // 
            this.TxtCodigoId.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodigoId.Enabled = false;
            this.TxtCodigoId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtCodigoId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCodigoId.Location = new System.Drawing.Point(25, 11);
            this.TxtCodigoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodigoId.MaxLength = 32767;
            this.TxtCodigoId.Multiline = false;
            this.TxtCodigoId.Name = "TxtCodigoId";
            this.TxtCodigoId.ReadOnly = false;
            this.TxtCodigoId.Size = new System.Drawing.Size(53, 33);
            this.TxtCodigoId.TabIndex = 37;
            this.TxtCodigoId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCodigoId.UseSystemPasswordChar = false;
            // 
            // FrmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 618);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtCodigoId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Empresas, Fabrica, Clientes, Arqt";
            this.Load += new System.EventHandler(this.FrmCadastroEmpresa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtCodigoId;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvCadastroEmpresa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Retaguarda.iTalk.iTalk_Button_1 BtnLimpar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnInserir;
        private Retaguarda.iTalk.iTalk_Button_1 BtnSalvar;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
    }
}