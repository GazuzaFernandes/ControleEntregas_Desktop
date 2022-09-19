using DALFinanceiro.Entities;
using DALFinanceiro.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_Financeiro_Estoque
{
    public partial class FrmEstoqueFinanceiro : Form
    {
        public int idmadeira;
        public string madeirass;
        public string medida;
        public decimal total;
        internal Madeira listarmadeiras;
        public FrmEstoqueFinanceiro()
        {
            InitializeComponent();
        }
        private void FrmEstoqueFinanceiro_Load(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
            Carregargrid();
            HabilitarCampos(false);
            LiberarBotao(false);
        }

        #region Apenas Metodos 
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLMadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.Madeiras.ToLower().Contains(pesquisa)).ToList();
                }
                dgvSaidaEstoque.DataSource = listarMadeira;
                MontarGrid(dgvSaidaEstoque);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvMaterial)
        {
            try
            {
                dgvSaidaEstoque.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvSaidaEstoque);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Madeiras", "UnidadeMedida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeiras", "Unid Medida", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 70, 10, 15 }, dgvSaidaEstoque.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtFabrica.Enabled = habilitar;
            txtMadeiras.Enabled = habilitar;
            txtEntrada.Enabled = habilitar;
            txtUnidadeMedida.Enabled = habilitar;
            btnSalvarData.Enabled = habilitar;
            txtSaida.Enabled = habilitar;
            btnLimpar.Enabled = habilitar;
            btnDeletarData.Enabled = habilitar;
            btnDeletarMaterial.Enabled = habilitar;
        }
        private void carregardata()
        {
            try
            {
                var listarData = new DLItensdata().Listar().Where(p => p.IdMadeiras == Convert.ToInt32(txtIdmadeira.Text)).ToList();
                DgvData.DataSource = null;
                DgvData.DataSource = listarData.OrderByDescending(p => p.Datas).ToList();
                DgvData.Refresh(); Montardata(DgvData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Montardata(DataGridView dgvData)
        {
            try
            {
                DgvData.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Fabrica", "Datas", "Entrada", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Fabrica", "Data", "Entrada" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 25, 25, 50 }, DgvData.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LiberarBotao(bool hab)
        {
            btnSalvarMaterial.Enabled = hab;
        }
        private Itensdata lerdata()
        {
            try
            {
                var iten = new Itensdata();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    iten.Datas = dtpData.Value;
                    iten.Fabrica = txtFabrica.Text;
                    iten.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    iten.IdMadeiras = Convert.ToInt32(txtIdmadeira.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            txtIdmadeira.Text = Convert.ToString(null);
            txtFabrica.Text = Convert.ToString(null);
            txtMadeiras.Text = Convert.ToString(null);
            txtUnidadeMedida.Text = Convert.ToString("m²");
            txtEntrada.Text = Convert.ToString(0);
            txtTotal.Text = Convert.ToString(null);
            txtDataId.Text = Convert.ToString(0);
        }
        private void CalcularSaida()
        {
            try
            {
                int id = 0;
                int.TryParse(txtSaida.Text, out id);
                if (id > 0)
                {
                    SaidadeMaterial();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SaidadeMaterial()
        {
            try
            {
                decimal saida = 0, saida2 = 0, total = 0;
                if (decimal.TryParse(txtSaida.Text, out saida))
                {
                    if (decimal.TryParse(txtTotalSaida.Text, out saida2))
                    {
                        total = saida2 - saida;
                    }
                }
                txtTotalSaida.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularEntrada()
        {
            try
            {
                decimal entrada = 0, total = 0, total2 = 0;
                if (decimal.TryParse(txtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(txtTotal.Text, out total))
                    {
                        total2 = entrada + total;
                    }
                    txtTotal.Text = total2.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion




        private void DgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ListarMadeiraStatus = dgvSaidaEstoque.Rows[e.RowIndex].DataBoundItem as Madeira;
                if (ListarMadeiraStatus != null)
                {
                    #region Cadastro Estoque
                    txtIdmadeira.Text = ListarMadeiraStatus.IdMadeiras.ToString();
                    txtFabrica.Text = ListarMadeiraStatus.Fabrica;
                    txtMadeiras.Text = ListarMadeiraStatus.Madeiras;
                    txtTotal.Text = ListarMadeiraStatus.Total.ToString();
                    txtUnidadeMedida.Text = ListarMadeiraStatus.UnidadeMedida;
                    #endregion

                    #region Saida Estoque
                    txtcodigo.Text = ListarMadeiraStatus.IdMadeiras.ToString();
                    txtMadeiraSaida.Text = ListarMadeiraStatus.Madeiras;
                    txtMedidaSaida.Text = ListarMadeiraStatus.UnidadeMedida;
                    txtTotalSaida.Text = ListarMadeiraStatus.Total.ToString();
                    #endregion

                    switch (ListarMadeiraStatus.StatusObraId)//escolha
                    {
                        case 1:
                            {
                                rbEngenharia.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                rbComercio.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbPisos.Checked = true;
                            }
                            break;
                    }
                }

                HabilitarCampos(true);
                carregardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvMaterial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvSaidaEstoque.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvSaidaEstoque.Rows[i].Cells[6].Value);
                switch (valor)
                {
                    case "1": dgvSaidaEstoque.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "2": dgvSaidaEstoque.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "3": dgvSaidaEstoque.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            CalcularSaida();
        }
        private void BtnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idmadeira = Convert.ToInt32(txtcodigo.Text);
                    madeirass = txtMadeiraSaida.Text;
                    medida = txtMedidaSaida.Text;
                    total = Convert.ToDecimal(txtSaida.Text);
                    int id = 0;
                    int.TryParse(txtcodigo.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLMadeira().ConsultarPorId(id);
                        madeiraAt.Total = Convert.ToDecimal(txtTotalSaida.Text);
                        new DLMadeira().Atualizar(madeiraAt);                      
                    }
                    Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            txtcodigo.Text = Convert.ToString(null);
            txtMadeiraSaida.Text = Convert.ToString(null);
            txtMedidaSaida.Text = Convert.ToString(null);
            txtSaida.Text = Convert.ToString(null);
            txtTotalSaida.Text = Convert.ToString(null);
            txtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
            Carregargrid();
        }
        private void BtnSalvarData_Click(object sender, EventArgs e)
        {
            try
            {
                var itenProposta = lerdata();
                int ItensPropostaId = 0;
                if (txtDataId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtIdmadeira.Text != "")
                {
                    propostaid = Convert.ToInt32(txtIdmadeira.Text);
                }
                var listarmadeira = new DLItensdata().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.IdMadeiras == propostaid //por proppostaid
                                && ip.IdDatas == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.IdDatas > 0)
                {
                    prop.IdDatas = Convert.ToInt32(txtDataId.Text);
                    prop.Datas = dtpData.Value;
                    prop.Fabrica = txtFabrica.Text;
                    prop.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    new DLItensdata().Atualizar(prop);
                }
                else
                {
                    new DLItensdata().Inserir(itenProposta);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }
                LiberarBotao(true);
                txtEntrada.Text = Convert.ToString(0);
                txtDataId.Text = Convert.ToString(0);
                carregardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvarMaterial_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdmadeira.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLMadeira().ConsultarPorId(id);
                        madeiraAt.IdMadeiras = Convert.ToInt32(txtIdmadeira.Text);
                        madeiraAt.Fabrica = txtFabrica.Text;
                        madeiraAt.Madeiras = txtMadeiras.Text;
                        madeiraAt.UnidadeMedida = txtUnidadeMedida.Text;
                        madeiraAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                        madeiraAt.Total = Convert.ToDecimal(txtTotal.Text);
                        if (rbEngenharia.Checked == true)
                            madeiraAt.StatusObraId = 1;
                        else if (rbComercio.Checked == true)
                            madeiraAt.StatusObraId = 2;
                        else if (rbPisos.Checked == true)
                            madeiraAt.StatusObraId = 3;
                        new DLMadeira().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        LimparCampos();
                        Carregargrid();
                        DgvData.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse Data ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtDataId.Text, out id);
                    if (id > 0)
                    {
                        new DLItensdata().Excluir(new Itensdata { IdDatas = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        txtDataId.Text = Convert.ToString(null);
                        carregardata();
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
        private void BtnDeletarMaterial_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdmadeira.Text, out id);
                    if (id > 0)
                    {
                        new DLMadeira().Excluir(new Madeira { IdMadeiras = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        Carregargrid();
                        LimparCampos();
                        txtIdmadeira.Text = Convert.ToString(null);
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
        private void TxtEntrada_TextChanged_1(object sender, EventArgs e)
        {
            CalcularEntrada();
        }
        private void BtnGerarId_Click_1(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var madeiras = new Madeira();
                madeiras.StatusObraId = 2;//Pendente
                var id = new DLMadeira().Inserir(madeiras);//inserir
                txtIdmadeira.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtDataId.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[0].Value);
            dtpData.Value = Convert.ToDateTime(DgvData.Rows[e.RowIndex].Cells[2].Value);
            txtEntrada.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[3].Value);
        }
        private void BtnLimparTudo_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            txtDataId.Text = Convert.ToString(null);
            DgvData.DataSource = null;
        }
        private void TxtTotal1_TextChanged_1(object sender, EventArgs e)
        {
            CalcularEntrada();
        }
        private void TxtPesquisar_Click_1(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(dgvSaidaEstoque);
        }
        private void TxtSaida_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
        }
        private void TxtSaida_TextChanged_1(object sender, EventArgs e)
        {
            CalcularSaida();
        }
    }
}
