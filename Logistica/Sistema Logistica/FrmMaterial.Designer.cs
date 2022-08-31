
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
            this.rbMaterial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterial = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.txtMaterialId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.rtbMaterial = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.rbutilizado = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btnSalvar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnDeletar = new Retaguarda.iTalk.iTalk_Button_1();
            this.btnLimpar = new Retaguarda.iTalk.iTalk_Button_1();
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
            this.rbMaterial.AutoSize = true;
            this.rbMaterial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.rbMaterial.ForeColor = System.Drawing.Color.White;
            this.rbMaterial.Location = new System.Drawing.Point(266, 22);
            this.rbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaterial.Name = "RbMaterial";
            this.rbMaterial.Size = new System.Drawing.Size(106, 29);
            this.rbMaterial.TabIndex = 70;
            this.rbMaterial.Text = "Material";
            this.rbMaterial.UseVisualStyleBackColor = true;
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
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.Color.Transparent;
            this.txtMaterial.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtMaterial.Location = new System.Drawing.Point(329, 72);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterial.MaxLength = 32767;
            this.txtMaterial.Multiline = false;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = false;
            this.txtMaterial.Size = new System.Drawing.Size(777, 33);
            this.txtMaterial.TabIndex = 62;
            this.txtMaterial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterial.UseSystemPasswordChar = false;
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.BackColor = System.Drawing.Color.Transparent;
            this.txtMaterialId.Enabled = false;
            this.txtMaterialId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaterialId.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaterialId.Location = new System.Drawing.Point(24, 18);
            this.txtMaterialId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterialId.MaxLength = 32767;
            this.txtMaterialId.Multiline = false;
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.ReadOnly = false;
            this.txtMaterialId.Size = new System.Drawing.Size(53, 33);
            this.txtMaterialId.TabIndex = 64;
            this.txtMaterialId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterialId.UseSystemPasswordChar = false;
            // 
            // rtbMaterial
            // 
            this.rtbMaterial.AutoWordSelection = false;
            this.rtbMaterial.BackColor = System.Drawing.Color.Transparent;
            this.rtbMaterial.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.rtbMaterial.ForeColor = System.Drawing.Color.Black;
            this.rtbMaterial.Location = new System.Drawing.Point(12, 120);
            this.rtbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbMaterial.Name = "rtbMaterial";
            this.rtbMaterial.ReadOnly = false;
            this.rtbMaterial.Size = new System.Drawing.Size(659, 118);
            this.rtbMaterial.TabIndex = 72;
            this.rtbMaterial.Text = "Para que é usado: ";
            this.rtbMaterial.WordWrap = true;
            // 
            // RButilizado
            // 
            this.rbutilizado.AutoSize = true;
            this.rbutilizado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.rbutilizado.ForeColor = System.Drawing.Color.White;
            this.rbutilizado.Location = new System.Drawing.Point(376, 22);
            this.rbutilizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbutilizado.Name = "RButilizado";
            this.rbutilizado.Size = new System.Drawing.Size(124, 29);
            this.rbutilizado.TabIndex = 70;
            this.rbutilizado.Text = "Utilização:";
            this.rbutilizado.UseVisualStyleBackColor = true;
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
            // txtPesquisar
            // 
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(506, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(343, 34);
            this.txtPesquisar.TabIndex = 74;
            this.txtPesquisar.Text = "Digite para Pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
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
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_96;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Location = new System.Drawing.Point(687, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 84);
            this.btnSalvar.TabIndex = 83;
            this.btnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_80;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Location = new System.Drawing.Point(849, 120);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 84);
            this.btnDeletar.TabIndex = 84;
            this.btnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_80;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Location = new System.Drawing.Point(1015, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 84);
            this.btnLimpar.TabIndex = 85;
            this.btnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
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
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtbMaterial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbutilizado);
            this.Controls.Add(this.rbMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtMaterialId);
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
        private System.Windows.Forms.RadioButton rbMaterial;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMaterial;
        private Retaguarda.iTalk.iTalk_TextBox_Small txtMaterialId;
        private Retaguarda.iTalk.iTalk_RichTextBox rtbMaterial;
        private System.Windows.Forms.RadioButton rbutilizado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label41;
        private Retaguarda.iTalk.iTalk_Button_1 btnSalvar;
        private Retaguarda.iTalk.iTalk_Button_1 btnDeletar;
        private Retaguarda.iTalk.iTalk_Button_1 btnLimpar;
    }
}