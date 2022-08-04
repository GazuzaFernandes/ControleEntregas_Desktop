﻿using DALLogistica.Repository;
using DALSenhas.Repository;
using System;

using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cancelou a solicitação!");
            Close();
        }      
        public void BtnEntrar_Click_1(object sender, EventArgs e)
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
        private void TxtSenha_Click_1(object sender, EventArgs e)
        {
            TxtSenha.Clear();
        }
    }
}