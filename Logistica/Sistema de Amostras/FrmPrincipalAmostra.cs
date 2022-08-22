using DALLogistica.Entities;
using DALLogistica.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Logistica.Sistema_de_Amostras
{
    public partial class FrmPrincipalAmostra : Form
    {
        public FrmPrincipalAmostra()
        {
            InitializeComponent();
        }
        private void FrmPrincipalAmostra_Load(object sender, EventArgs e)
        {
            var listagemMontagem = new DLMontagem().Listar();
            CarregarMontagem();

            var listaAamostraCliente = new DLAmostra().Listar();
            CarregarAmostras();

            var listarAmostra = new DLAmostraCliente().Listar();
            CarregarAmostra();
        }
        private void CarregarAmostras(bool isPesquisa = false)
        {
            try
            {
                var listarAmostra2022 = new DLAmostra().ListarAmostra();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked)
                        listarAmostra2022 = listarAmostra2022.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEndereco.Checked)
                        listarAmostra2022 = listarAmostra2022.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                     else if (RbAmostra.Checked)
                        listarAmostra2022 = listarAmostra2022.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvAmostraa.DataSource = listarAmostra2022.OrderByDescending(p => p.dataentrega).ToList();  
                MontarGrid(DgvAmostraa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvAA)
        {
            DgvAmostraa.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvAmostraa);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "construtora", "dataentrega", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cliente / Arqt", "Data da Entrega", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 55, }, DgvAmostraa.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarAmostra(bool isPesquisa = false)
        {
            try
            {
                var listarAmostra2021 = new DLAmostraCliente().ListarAmostraclienteStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEndereco.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (RbAmostra.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvAmostra.DataSource = listarAmostra2021.OrderByDescending(p => p.dataentrega).ToList(); 
                MontarAmostras(DgvAmostra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarAmostras(DataGridView dgvAmostra)
        {
            DgvAmostra.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvAmostra);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() {  "construtora", "dataentrega", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() {  "Cliente / Arqt", "Data da Entrega", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() {  25, 15, 53, }, DgvAmostra.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarMontagem(bool isPesquisa = false)
        {
            try
            {
                var listarMontagem = new DLMontagem().ListarMontagem();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked);
                    
                }
                DgvMontagem.DataSource = listarMontagem; 
                MontarMontagem(DgvMontagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarMontagem(DataGridView dgvMontagem)
        {
            DgvMontagem.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvMontagem);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() {  "montador", "dataenvio", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() {  "Montador", "Data do Envio", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() {  25, 15, 53, }, DgvMontagem.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }  
        private void BtnMontagemAmostra_Click(object sender, EventArgs e)
        {
            FrmMontagemAmostras montagem = new FrmMontagemAmostras();
            montagem.ShowDialog();
            CarregarMontagem();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarAmostra(true);
            MontarAmostras(DgvAmostra);
            CarregarAmostras(true);
            MontarGrid(DgvAmostraa);
            CarregarMontagem(true);
            MontarMontagem(DgvMontagem);
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new AmostraCliente();
                prop.amostraid = Convert.ToInt32(DgvAmostra.Rows[e.RowIndex].Cells[0].Value);             
                CarregarAmostra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvAmostra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvAmostra.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvAmostra.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvMontagemAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new Montagem();
                prop.montagemid = Convert.ToInt32(DgvMontagem.Rows[e.RowIndex].Cells[0].Value);
                FrmMontagemAmostras montagem = new FrmMontagemAmostras();
                montagem._montagem = prop;
                montagem.ShowDialog();
                CarregarMontagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvMontagemAmostra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvMontagem.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvMontagem.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }      
        private void FrmPrincipalAmostra_Click(object sender, EventArgs e)
        {
            CarregarAmostras();
            CarregarMontagem();
        }
        private void iTalk_TabControl1_Click(object sender, EventArgs e)
        {
            CarregarAmostras();
            CarregarMontagem();
        }
        private void BtnAmostra_Click(object sender, EventArgs e)
        {
            FrmAmostra amostra = new FrmAmostra();
            amostra.ShowDialog();
            CarregarAmostras();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueAmostra estoque = new FrmEstoqueAmostra();
            estoque.Show();
        }
        private void DgvAmostraa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvAmostraa.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvAmostraa.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvAmostraa.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvAmostraa.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvAmostraa.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }

        }
        private void DgvAmostraa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var amos = new Amostra();
                amos.amostraid = Convert.ToInt32(DgvAmostraa.Rows[e.RowIndex].Cells[0].Value);
                FrmAmostra amostra = new FrmAmostra();
                amostra._amostracliente = amos;
                amostra.ShowDialog();
                CarregarAmostras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString("Digite para pesquisar:");
            RbCliente.Checked = false;
             RbEndereco.Checked = false;
            RbAmostra.Checked = false;
            CarregarAmostras();
            CarregarAmostra();
            CarregarMontagem();
        }
        private void FrmPrincipalAmostra_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FunctionsDataBase.BackupDatabase(
                                             "192.168.0.202",
                                             "5432",
                                             "postgres",
                                             "q1s2e3f4t5",
                                             "RBCOMERCIO",
                                           $@"C:\Users\logistica\source\repos\BACKUP\SistemaAmostras\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaAmostras");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarAmostra(true);
            MontarAmostras(DgvAmostra);
            CarregarAmostras(true);
            MontarGrid(DgvAmostraa);
        }
    }
}
