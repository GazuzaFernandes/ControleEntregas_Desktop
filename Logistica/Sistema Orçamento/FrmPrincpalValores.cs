﻿using DALOrcamento.Entities;
using DALOrcamento.Repository;
using DALSenhas.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Logistica.Sistema_Controle_de_Preços
{
    public partial class FrmPrincpalValores : Form
    {
        public FrmPrincpalValores()
        {
            InitializeComponent();
        }
        private void FrmPrincpalValores_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProp = new DLProdutos().Listar();
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarEmpresa = new DLProdutos().Listar();             
                DgvValores.DataSource = listarEmpresa.OrderBy(p => p.fornecedor).ToList(); ;
                montargrid(DgvValores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void montargrid(DataGridView dgvValores)
        {
            DgvValores.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvValores);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "fornecedor", "produto", "preco", "rendimento", "comentario" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Fornecedor", "Produto", "Preço", "Rendimento", "Descrição" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 35, 20, 10, 20 }, DgvValores.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarValores cadastrar = new FrmCadastrarValores();
            cadastrar.ShowDialog();
            Carregargrid();
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var listarEmpresa = new DLProdutos().Listar();              
                    var pesquisa = TxtPesquisar.Text.ToLower();
                        listarEmpresa = listarEmpresa.Where(p => p.produto.ToLower().Contains(pesquisa)).ToList();               
                DgvValores.DataSource = listarEmpresa.OrderBy(p => p.fornecedor).ToList(); ;
                montargrid(DgvValores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvValores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var valo = new Produtos();
                valo.produtoid = Convert.ToInt32(DgvValores.Rows[e.RowIndex].Cells[0].Value);
                FrmCadastrarValores vaalores = new FrmCadastrarValores();
                vaalores._produto = valo;
                vaalores.ShowDialog();
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void BtnLimparPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar");
            Carregargrid();
        }
        private void FrmPrincpalValores_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FunctionsDataBase.BackupDatabase(
                                                  "192.168.0.202",
                                                  "5432",
                                                  "postgres",
                                                  "q1s2e3f4t5",
                                                  "RBORCAMENTO",
                                               $@"C:\Users\logistica\source\repos\BACKUP\SistemaControle\{ DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                                  @"SistemaControle");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}
