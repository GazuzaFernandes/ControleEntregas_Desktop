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
                if (_montagem.montagemid > 0)
                {
                    _montagem = new DLMontagem().ConsultarPorId(_montagem.montagemid);

                    TxtMontagemId.Text = _montagem.montagemid.ToString();
                    DtpDataentrega.Value = _montagem.dataenvio;
                    TxtMontador.Text = _montagem.montador;
                    TxtObra.Text = _montagem.obra;
                    Rtbmaterial.Text = _montagem.material;
                    switch (_montagem.statusobraid)//escolha
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
                        case 4:
                            {
                                RbCancelado.Checked = true;
                            }
                            break;                    }
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
            DtpDataentrega.Value = DateTime.Now;
            TxtMontador.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            Rtbmaterial.Text = Convert.ToString(null);
        }
        private bool Validarcampos()
        {
            if (TxtMontador.Text == "")
            {
                throw new Exception("Informe o Montador");
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
                    int.TryParse(TxtMontagemId.Text, out id);
                    if (id > 0)
                    {
                        var clienteatualizar = new DLMontagem().ConsultarPorId(id);

                        clienteatualizar.dataenvio = DtpDataentrega.Value;
                        clienteatualizar.montador = TxtMontador.Text;
                        clienteatualizar.obra = TxtObra.Text;
                        clienteatualizar.material = Rtbmaterial.Text;

                        if (RbPendente.Checked == true)
                            clienteatualizar.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            clienteatualizar.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            clienteatualizar.statusobraid = 4;

                        new DLMontagem().Atualizar(clienteatualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                        LimparCampos();

                    }
                    else
                    {
                        var clientenovo = new Montagem();
                        clientenovo.dataenvio = DtpDataentrega.Value;
                        clientenovo.montador = TxtMontador.Text;
                        clientenovo.obra = TxtObra.Text;
                        clientenovo.material = Rtbmaterial.Text;
                        if (RbPendente.Checked == true)
                            clientenovo.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            clientenovo.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            clientenovo.statusobraid = 4;
                        var idproposta = new DLMontagem().Inserir(clientenovo);
                        MessageBox.Show(" Amostra " + idproposta + " Criado com Sucesso! ");
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
                var pergunta = "Deseja realmente excluir essa amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtMontagemId.Text, out id);
                    if (id > 0)
                    {
                        new DLMontagem().Excluir(new Montagem { montagemid = id });
                        MessageBox.Show("Amostra excluída com sucesso!");
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
    }
}
