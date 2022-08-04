using DALLogistica.Repository;
using DALSenhas.Repository;
using System;
using System.Windows.Forms;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Restauracao
{
    public partial class FrmRestauracao : Form
    {
        public FrmRestauracao()
        {
            InitializeComponent();
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean temUsuario = false;
                var listaUsuarios = new DLsenha().Listar();
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].senhass == TxtSenha.Text)
                    {
                        temUsuario = true;
                    }
                }
                if (temUsuario == true)
                {
                    #region Restauração
                    OpenFileDialog od = new OpenFileDialog();
                    od.ShowDialog();
                    var arquivo = od.FileName;
                    FunctionsDataBase.RestoreDatabase("192.168.0.202",
                                                    "5432",
                                                    "postgres",
                                                    "q1s2e3f4t5",
                                                    "RBCOMERCIO",
                                                    arquivo);
                    MessageBox.Show("Sistema Restaurado com Sucesso !");
                    #endregion
                    Close();
                }
                else
                {
                    MessageBox.Show("Senha inválida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cancelou a solicitação!");
            Close();
        }
        private void TxtSenha_Click(object sender, EventArgs e)
        {
            TxtSenha.Clear();
        }
    }
}
