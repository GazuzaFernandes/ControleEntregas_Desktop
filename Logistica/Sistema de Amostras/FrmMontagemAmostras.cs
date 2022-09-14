using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmMontagemAmostras : Form
    {
        internal Montagem _montagem;
        public FrmMontagemAmostras()
        {
            InitializeComponent();
        }
        private void FrmMontagemAmostras_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                if (_montagem == null)
                    _montagem = new Montagem();
                if (_montagem.MontagemId > 0)
                {
                    _montagem = new DLMontagem().ConsultarPorId(_montagem.MontagemId);
                    txtMontagemId.Text = _montagem.MontagemId.ToString();
                    dtpDataentrega.Value = _montagem.DataEnvio;
                    txtMontador.Text = _montagem.Montador;
                    txtObra.Text = _montagem.Obra;
                    rtbmaterial.Text = _montagem.Material;
                    switch (_montagem.StatusobraId)//escolha
                    {
                        case 2:
                            {
                                rbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                rbCancelado.Checked = true;
                            }
                            break;
                    }
                }
                else
                {
                    rbPendente.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtMontagemId.Text, out id);
                    if (id > 0)
                    {
                        var montagemAtualizar = new DLMontagem().ConsultarPorId(id);
                        montagemAtualizar.DataEnvio = dtpDataentrega.Value;
                        montagemAtualizar.Montador = txtMontador.Text;
                        montagemAtualizar.Obra = txtObra.Text;
                        montagemAtualizar.Material = rtbmaterial.Text;
                        if (rbPendente.Checked == true)
                            montagemAtualizar.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            montagemAtualizar.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            montagemAtualizar.StatusobraId = 4;
                        new DLMontagem().Atualizar(montagemAtualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                    }
                    else
                    {
                        var montagemNovo = new Montagem();
                        montagemNovo.DataEnvio = dtpDataentrega.Value;
                        montagemNovo.Montador = txtMontador.Text;
                        montagemNovo.Obra = txtObra.Text;
                        montagemNovo.Material = rtbmaterial.Text;
                        if (rbPendente.Checked == true)
                            montagemNovo.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            montagemNovo.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            montagemNovo.StatusobraId = 4;
                        var idproposta = new DLMontagem().Inserir(montagemNovo);
                        MessageBox.Show(" Amostra " + idproposta + " Criado com Sucesso! ");                       
                    }
                    LimparCampos();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja realmente excluir essa montagem ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtMontagemId.Text, out id);
                    if (id > 0)
                    {
                        new DLMontagem().Excluir(new Montagem { MontagemId = id });
                        MessageBox.Show("Montagem excluída com sucesso!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Apenas Metodos
        private void LimparCampos()
        {
            dtpDataentrega.Value = DateTime.Now;
            txtMontador.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
            rtbmaterial.Text = Convert.ToString(null);
        }
        private bool ValidarCampos()
        {
            if (txtMontador.Text == "")
            {
                throw new Exception("Informe o Montador");
            }
            return true;
        }
        #endregion
    }
}
