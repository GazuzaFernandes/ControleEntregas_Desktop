using DALLogistica.Entities;
using DALLogistica.Repository;
using Logistica.Sistema_de_Amostras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmAmostraCliente : Form
    {
        internal amostracliente _amostracliente;
        public FrmAmostraCliente()
        {
            InitializeComponent();
        }
        private void FrmAmostraCliente_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                if (_amostracliente == null)
                    _amostracliente = new amostracliente();
                if (_amostracliente.amostraid > 0)
                {
                    _amostracliente = new DLamostracliente().ConsultarPorId(_amostracliente.amostraid);
                    TxtPropostaID.Text = _amostracliente.amostraid.ToString();
                    DtpDataentrega.Value = _amostracliente.dataentrega;
                    TxtConstrutora.Text = _amostracliente.construtora;
                    TxtObra.Text = _amostracliente.obra;
                    Rtbmaterial.Text = _amostracliente.material;
                    switch (_amostracliente.statusobraid)//escolha
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
        private bool Validarcampos()
        {
            if (TxtConstrutora.Text == "")
            {
                throw new Exception("Informe o Cliente");
            }
            return true;
        }
        private void LimparAmostra()
        {
            DtpDataentrega.Value = DateTime.Now;
            TxtConstrutora.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            Rtbmaterial.Text = Convert.ToString(null);
        }   

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtPropostaID.Text, out id);
                    if (id > 0)
                    {
                        var clienteatualizar = new DLamostracliente().ConsultarPorId(id);
                        clienteatualizar.dataentrega = DtpDataentrega.Value;
                        clienteatualizar.construtora = TxtConstrutora.Text;
                        clienteatualizar.obra = TxtObra.Text;
                        clienteatualizar.material = Rtbmaterial.Text;
                        if (RbPendente.Checked == true)
                            clienteatualizar.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            clienteatualizar.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            clienteatualizar.statusobraid = 4;
                        new DLamostracliente().Atualizar(clienteatualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                        LimparAmostra();

                    }
                    else
                    {
                        var clientenovo = new amostracliente();
                        clientenovo.dataentrega = DtpDataentrega.Value;
                        clientenovo.construtora = TxtConstrutora.Text;
                        clientenovo.obra = TxtObra.Text;
                        clientenovo.material = Rtbmaterial.Text;
                        if (RbPendente.Checked == true)
                            clientenovo.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            clientenovo.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            clientenovo.statusobraid = 4;
                        var idproposta = new DLamostracliente().Inserir(clientenovo);
                        MessageBox.Show(" Amostra " + idproposta + " Criado com Sucesso! ");
                        LimparAmostra();
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
                var pergunta = "Deseja Realmente excluir essa Amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtPropostaID.Text, out id);
                    if (id > 0)
                    {
                        new DLamostracliente().Excluir(new amostracliente { amostraid = id });
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            FrmAmostra amostra = new FrmAmostra();
            amostra.Show();
        }
    }
}
