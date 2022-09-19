using DALLogistica.Entities;
using DALLogistica.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_de_Amostras
{
    public partial class FrmAmostra : Form
    {
        internal Amostra _amostracliente;
        public FrmAmostra()
        {
            InitializeComponent();
        }
        private void FrmAmostra_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
           
                if (_amostracliente == null)
                    _amostracliente = new Amostra();
                if (_amostracliente.AmostraId > 0)
                {
                    HabilitarCampos(true);
                    _amostracliente = new DLAmostra().ConsultarPorId(_amostracliente.AmostraId);
                    txtAmostraId.Text = _amostracliente.AmostraId.ToString();
                    dtpDataentrega.Value = _amostracliente.DataEntrega;
                    rtbComentario.Text = _amostracliente.Material;
                    txtConstrutora.Text = _amostracliente.Construtora;
                    txtObra.Text = _amostracliente.Obra;
                    switch (_amostracliente.StatusobraId)//escolha
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
                    BloquearBotao(false);                  
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

        #region Apenas Metodos

        private bool ValidarCampos()
        {
            if (txtConstrutora.Text == "")
            {
                throw new Exception("Informe o Cliente");
            }
            else if (rtbComentario.Text == "")
            {
                throw new Exception("Informe o material");
            }
            return true;
        }
        private void LimparAmostra()
        {
            dtpDataentrega.Value = DateTime.Now;
            txtConstrutora.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
        }
        private void SalvarComentario()
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLItensAmostra().ConsultarPorId(id);
                        atualizar.Material = rtbComentario.Text;
                        new DLItensAmostra().Inserir(atualizar);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BloquearBotao(bool bloquear)
        {
            btnGerarAmostra.Enabled = bloquear;
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtConstrutora.Enabled = habilitar;
            txtObra.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
        
        }
        #endregion

        #region Tela de Dados de Envio

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLAmostra().ConsultarPorId(id);
                        atualizar.DataEntrega = dtpDataentrega.Value;
                        atualizar.Construtora = txtConstrutora.Text;
                        atualizar.Obra = txtObra.Text;
                        atualizar.Material = rtbComentario.Text;
                        if (rbPendente.Checked == true)
                            atualizar.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            atualizar.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            atualizar.StatusobraId = 4;
                        new DLAmostra().Atualizar(atualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
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
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa Amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        new DLAmostra().Excluir(new Amostra { AmostraId = id });
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
        private void BtnGerarAmostra_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var amostra = new Amostra();
                amostra.StatusobraId = 2;//Pendente
                var id = new DLAmostra().Inserir(amostra);//inserir
                txtAmostraId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        #endregion


    }
}
