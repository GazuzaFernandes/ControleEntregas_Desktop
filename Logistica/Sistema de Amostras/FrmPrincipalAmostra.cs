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
            CarregarGridMontagem();
            CarregarGridAmostras();
            CarregarGridAmostra2021();
        }
        private void CarregarGridAmostras(bool isPesquisa = false)
        {
            try
            {
                var listaAmostra = new DLAmostra().ListarAmostra();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)
                        listaAmostra = listaAmostra.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (rbEndereco.Checked)
                        listaAmostra = listaAmostra.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbAmostra.Checked)
                        listaAmostra = listaAmostra.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvAmostra.DataSource = listaAmostra.OrderByDescending(p => p.dataentrega).ToList();
                MontarGridAmostra(DgvAmostra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridAmostra(DataGridView dgvamostra)
        {
            DgvAmostra.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvAmostra);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "construtora", "dataentrega", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cliente / Arqt", "Data da Entrega", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 55, }, DgvAmostra.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarGridAmostra2021(bool isPesquisa = false)
        {
            try
            {
                var listarAmostra2021 = new DLAmostraCliente().ListarAmostraclienteStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (rbEndereco.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbAmostra.Checked)
                        listarAmostra2021 = listarAmostra2021.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvAmostra2021.DataSource = listarAmostra2021.OrderByDescending(p => p.dataentrega).ToList();
                MontarGridAmostras2021(DgvAmostra2021);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridAmostras2021(DataGridView dgvAmostra)
        {
            DgvAmostra2021.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvAmostra2021);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "construtora", "dataentrega", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cliente / Arqt", "Data da Entrega", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 53, }, DgvAmostra2021.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarGridMontagem(bool isPesquisa = false)
        {
            try
            {
                var listarMontagem = new DLMontagem().ListarMontagem();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)
                        listarMontagem = listarMontagem.Where(p => p.montador.ToLower().Contains(pesquisa)).ToList();
                }
                DgvMontagem.DataSource = listarMontagem;
                MontarGridMontagem(DgvMontagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridMontagem(DataGridView dgvMontagem)
        {
            DgvMontagem.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvMontagem);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Montador", "DataEnvio", "Obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Montador", "Data do Envio", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 53, }, DgvMontagem.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void BtnMontagemAmostra_Click(object sender, EventArgs e)
        {
            FrmMontagemAmostras montagem = new FrmMontagemAmostras();
            montagem.ShowDialog();
            CarregarGridMontagem();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGridAmostra2021(true);
            MontarGridAmostras2021(DgvAmostra2021);
            CarregarGridAmostras(true);
            MontarGridAmostra(DgvAmostra);
            CarregarGridMontagem(true);
            MontarGridMontagem(DgvMontagem);
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new AmostraCliente();
                prop.AmostraId = Convert.ToInt32(DgvAmostra2021.Rows[e.RowIndex].Cells[0].Value);
                CarregarGridAmostra2021();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvAmostra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvAmostra2021.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvAmostra2021.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvAmostra2021.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvAmostra2021.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvAmostra2021.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvMontagemAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new Montagem();
                prop.MontagemId = Convert.ToInt32(DgvMontagem.Rows[e.RowIndex].Cells[0].Value);
                FrmMontagemAmostras montagem = new FrmMontagemAmostras();
                montagem._montagem = prop;
                montagem.ShowDialog();
                CarregarGridMontagem();
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
            txtPesquisar.Clear();
        }
        private void FrmPrincipalAmostra_Click(object sender, EventArgs e)
        {
            CarregarGridAmostras();
            CarregarGridMontagem();
        }
        private void iTalk_TabControl1_Click(object sender, EventArgs e)
        {
            CarregarGridAmostras();
            CarregarGridMontagem();
        }
        private void BtnAmostra_Click(object sender, EventArgs e)
        {
            FrmAmostra amostra = new FrmAmostra();
            amostra.ShowDialog();
            CarregarGridAmostras();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueAmostra estoque = new FrmEstoqueAmostra();
            estoque.Show();
        }
        private void DgvAmostraa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
        private void DgvAmostraa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var amos = new Amostra();
                amos.AmostraId = Convert.ToInt32(DgvAmostra.Rows[e.RowIndex].Cells[0].Value);
                FrmAmostra amostra = new FrmAmostra();
                amostra._amostracliente = amos;
                amostra.ShowDialog();
                CarregarGridAmostras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString("Digite para pesquisar:");
            rbCliente.Checked = false;
            rbEndereco.Checked = false;
            rbAmostra.Checked = false;
            CarregarGridAmostras();
            CarregarGridAmostra2021();
            CarregarGridMontagem();
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
                                           $@"F:\_LOGISTICA\Restauração\SistemaAmostras\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaAmostras");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGridAmostra2021(true);
            MontarGridAmostras2021(DgvAmostra2021);
            CarregarGridAmostras(true);
            MontarGridAmostra(DgvAmostra);
        }
    }
}
