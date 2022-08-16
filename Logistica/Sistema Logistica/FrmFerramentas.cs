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
                if (_ferramentas.ferramentaid > 0)
                {
                    _ferramentas = new DLFerramentas().ConsultarPorId(_ferramentas.ferramentaid);
                    TxtFerramentaId.Text = _ferramentas.ferramentaid.ToString();
                    DtpRetirada.Value = _ferramentas.retirada;
                    DtpDevolucao.Value = _ferramentas.devolucao;
                    TxtNome.Text = _ferramentas.funcionario;
                    RtbEquipamento.Text = _ferramentas.material;
                    switch (_ferramentas.statusobraid)//escolha
                    {
                        case 2:
                            {
                                RbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                RbFinalizado.Checked = true;
                            }
                            break;
                    }
                }
                else
                {
                    RbPendente.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }      
        private void LimparCampos()
        {
            DtpRetirada.Value = DateTime.Now;
            DtpDevolucao.Value = DateTime.Now;
            TxtNome.Text = Convert.ToString(null);
            RtbEquipamento.Text = Convert.ToString(null);          
        }
        private bool Validarcampos()
        {
            if (TxtNome.Text == "")
            {
                throw new Exception(" Informe quem Retirou ");
            }
            return true;            
        }   
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLFerramentas().ConsultarPorId(id);
                        atualizar.devolucao = DtpDevolucao.Value;
                        atualizar.retirada = DtpRetirada.Value;
                        atualizar.funcionario = TxtNome.Text;
                        atualizar.material = RtbEquipamento.Text;
                        if (RbPendente.Checked == true)
                            atualizar.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            atualizar.statusobraid = 3;
                        new DLFerramentas().Atualizar(atualizar);
                        MessageBox.Show("Material devolvido com Sucesso!");
                        LimparCampos();
                    }
                    else
                    {
                        var clientenovo = new Ferramentas();
                        clientenovo.devolucao = DtpDevolucao.Value;
                        clientenovo.retirada = DtpRetirada.Value;
                        clientenovo.funcionario = TxtNome.Text;
                        clientenovo.material = RtbEquipamento.Text;
                        if (RbPendente.Checked == true)
                            clientenovo.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            clientenovo.statusobraid = 3;
                        var idproposta = new DLFerramentas().Inserir(clientenovo);
                        MessageBox.Show(" Material " + idproposta + " Retirado com Sucesso! ");
                        LimparCampos();
                    }
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
                    int.TryParse(TxtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        new DLFerramentas().Excluir(new Ferramentas { ferramentaid = id });
                        MessageBox.Show("Funcionario excluída com sucesso!");
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
                FrmImpressaoFerramentas frmImpressao = new FrmImpressaoFerramentas(DtpRetirada.Value, TxtNome.Text, RtbEquipamento.Text);
                frmImpressao.reportViewer1.LocalReport.DataSources.Clear();
                frmImpressao.reportViewer1.LocalReport.ReportEmbeddedResource = "Logistica.Ferramentas.rdlc";
                frmImpressao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
