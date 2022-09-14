using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmFerramentas : Form
    {
        internal Ferramentas _ferramentas;
        public FrmFerramentas()
        {
            InitializeComponent();
        }
        private void FrmFerramentas_Load(object sender, EventArgs e)
        {
            try
            {

                if (_ferramentas == null)
                    _ferramentas = new Ferramentas();
                if (_ferramentas.FerramentaId > 0)
                {
                    _ferramentas = new DLFerramentas().ConsultarPorId(_ferramentas.FerramentaId);
                    txtFerramentaId.Text = _ferramentas.FerramentaId.ToString();
                    dtpRetirada.Value = _ferramentas.Retirada;
                    dtpDevolucao.Value = _ferramentas.Devolucao;
                    txtNome.Text = _ferramentas.Funcionario;
                    rtbEquipamento.Text = _ferramentas.Material;
                    switch (_ferramentas.StatusobraId)//escolha
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
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLFerramentas().ConsultarPorId(id);
                        atualizar.Devolucao = dtpDevolucao.Value;
                        atualizar.Retirada = dtpRetirada.Value;
                        atualizar.Funcionario = txtNome.Text;
                        atualizar.Material = rtbEquipamento.Text;
                        if (rbPendente.Checked == true)
                            atualizar.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            atualizar.StatusobraId = 3;
                        new DLFerramentas().Atualizar(atualizar);
                        MessageBox.Show("Material devolvido com Sucesso!");                        
                    }
                    else
                    {
                        var novo = new Ferramentas();
                        novo.Devolucao = dtpDevolucao.Value;
                        novo.Retirada = dtpRetirada.Value;
                        novo.Funcionario = txtNome.Text;
                        novo.Material = rtbEquipamento.Text;
                        if (rbPendente.Checked == true)
                            novo.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            novo.StatusobraId = 3;
                        var idferramentas = new DLFerramentas().Inserir(novo);
                        MessageBox.Show(" Material " + idferramentas + " Retirado com Sucesso! ");                        
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
                var pergunta = "Deseja realmente deletar o material que o funcionario retirou ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        new DLFerramentas().Excluir(new Ferramentas { FerramentaId = id });
                        MessageBox.Show("Ferramenta excluída com sucesso!");
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
        private void BtnImpressao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmImpressaoFerramentas impressao = new FrmImpressaoFerramentas(dtpRetirada.Value, txtNome.Text, rtbEquipamento.Text);
                impressao.reportViewer1.LocalReport.DataSources.Clear();
                impressao.reportViewer1.LocalReport.ReportEmbeddedResource = "Logistica.Ferramentas.rdlc";
                impressao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Campo de Metodos
        private void LimparCampos()
        {
            dtpRetirada.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            txtNome.Text = Convert.ToString(null);
            rtbEquipamento.Text = Convert.ToString(null);
        }
        private bool ValidarCampos()
        {
            if (txtNome.Text == "")
            {
                throw new Exception(" Informe quem Retirou ");
            }
            return true;
        }

        #endregion

    }
}
