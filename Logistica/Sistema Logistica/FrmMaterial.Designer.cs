
namespace LogisticaEntregas
{
    partial class FrmMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvMaterial = new System.Windows.Forms.DataGridView();
            this.RbMaterial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaterial = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.RtbMaterial = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.RButilizado = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.BtnLimpar = new Retaguarda.iTalk.iTalk_Button_1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvMaterial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 282);
            this.panel1.TabIndex = 71;
            // 
            // DgvMaterial
            // 
            this.DgvMaterial.AllowUserToAddRows = false;
            this.DgvMaterial.AllowUserToDeleteRows = false;
            this.DgvMaterial.BackgroundColor = System.Drawing.Color.White;
            this.DgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.DgvMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMaterial.Name = "DgvMaterial";
            this.DgvMaterial.ReadOnly = true;
            this.DgvMaterial.RowHeadersWidth = 51;
            this.DgvMaterial.RowTemplate.Height = 29;
            this.DgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMaterial.Size = new System.Drawing.Size(1304, 282);
            this.DgvMaterial.TabIndex = 0;
            this.DgvMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterial_CellDoubleClick);
            // 
            // RbMaterial
            // 
            this.RbMaterial.AutoSize = true;
            this.RbMaterial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.RbMaterial.ForeColor = System.Drawing.Color.White;
            this.RbMaterial.Location = new System.Drawing.Point(266, 22);
            this.RbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbMaterial.Name = "RbMaterial";
            this.RbMaterial.Size = new System.Drawing.Size(106, 29);
            this.RbMaterial.TabIndex = 70;
            this.RbMaterial.Text = "Material";
            this.RbMaterial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 67;
            this.label2.Text = "Material:";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.BackColor = System.Drawing.Color.Transparent;
            this.TxtMaterial.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMaterial.ForeColor = System.Drawing.Color.Black;
            this.TxtMaterial.Location = new System.Drawing.Point(329, 72);
            this.TxtMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMaterial.MaxLength = 32767;
            this.TxtMaterial.Multiline = false;
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.ReadOnly = false;
            this.TxtMaterial.Size = new System.Drawing.Size(777, 33);
            this.TxtMaterial.TabIndex = 62;
            this.TxtMaterial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMaterial.UseSystemPasswordChar = false;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.Transparent;
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtId.Location = new System.Drawing.Point(24, 18);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Multiline = false;
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = false;
            this.TxtId.Size = new System.Drawing.Size(53, 33);
            this.TxtId.TabIndex = 64;
            this.TxtId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtId.UseSystemPasswordChar = false;
            // 
            // RtbMaterial
            // 
            this.RtbMaterial.AutoWordSelection = false;
            this.RtbMaterial.BackColor = System.Drawing.Color.Transparent;
            this.RtbMaterial.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.RtbMaterial.ForeColor = System.Drawing.Color.Black;
            this.RtbMaterial.Location = new System.Drawing.Point(12, 120);
            this.RtbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RtbMaterial.Name = "RtbMaterial";
            this.RtbMaterial.ReadOnly = false;
            this.RtbMaterial.Size = new System.Drawing.Size(659, 118);
            this.RtbMaterial.TabIndex = 72;
            this.RtbMaterial.Text = "Para que é usado: ";
            this.RtbMaterial.WordWrap = true;
            // 
            // RButilizado
            // 
            this.RButilizado.AutoSize = true;
            this.RButilizado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.RButilizado.ForeColor = System.Drawing.Color.White;
            this.RButilizado.Location = new System.Drawing.Point(376, 22);
            this.RButilizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RButilizado.Name = "RButilizado";
            this.RButilizado.Size = new System.Drawing.Size(124, 29);
            this.RButilizado.TabIndex = 70;
            this.RButilizado.Text = "Utilização:";
            this.RButilizado.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(1170, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisar.Location = new System.Drawing.Point(506, 17);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.TxtPesquisar.TabIndex = 74;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1018, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Limpar Campos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(877, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Deletar ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(721, 207);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(54, 17);
            this.label41.TabIndex = 88;
            this.label41.Text = "Salvar";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_96;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(687, 120);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(122, 84);
            this.BtnSalvar.TabIndex = 83;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeletar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_80;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(849, 120);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(122, 84);
            this.BtnDeletar.TabIndex = 84;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_80;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimpar.Location = new System.Drawing.Point(1015, 120);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(122, 84);
            this.BtnLimpar.TabIndex = 85;
            this.BtnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1304, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RtbMaterial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RButilizado);
            this.Controls.Add(this.RbMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.TxtId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações de Materiais";
            this.Load += new System.EventHandler(this.FrmMaterial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvMaterial;
        private System.Windows.Forms.RadioButton RbMaterial;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtMaterial;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtId;
        private Retaguarda.iTalk.iTalk_RichTextBox RtbMaterial;
        private System.Windows.Forms.RadioButton RButilizado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label41;
        private Retaguarda.iTalk.iTalk_Button_1 BtnSalvar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 BtnLimpar;
    }
}