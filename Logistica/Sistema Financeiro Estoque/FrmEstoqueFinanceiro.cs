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

        internal madeira _madeira;
        public FrmEstoqueFinanceiro()
        {
            InitializeComponent();
        }
        private void FrmEstoqueFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                Carregargrid();
                HabilitarCampos(false);
                Liberarbotao(false);
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
                var listarmadeira = new DLmadeira().ListarMadeiraStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower(); if (RbMaterial.Checked)
                        listarmadeira = listarmadeira.Where(p => p.madeiras.ToLower().Contains(pesquisa)).ToList();
                }
                DgvMaterial.DataSource = listarmadeira; MontarGrid(DgvMaterial);
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
                DgvMaterial.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "madeiras", "unidademedida", "total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeiras", "Unid Medida", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 70, 10, 15 }, DgvMaterial.Width - 15); //O total tem que ficar em 100% 
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
        private void HabilitarCampos(bool habilitar)
        {
            TxtFabrica.Enabled = habilitar;
            TxtMadeiras.Enabled = habilitar;
            TxtEntrada.Enabled = habilitar;
            TxtUnidadeMedida.Enabled = habilitar;
            BtnSalvarData.Enabled = habilitar;
            TxtSaida.Enabled = habilitar;
            BtnLimpar.Enabled = habilitar;
            BtnDeletarData.Enabled = habilitar;
            BtnDeletarMaterial.Enabled = habilitar;
        }
        private void carregardata()
        {
            try
            {
                var listar = new DLitensdata().Listar().Where(p => p.idmadeiras == Convert.ToInt32(TxtIdmadeira.Text)).ToList();
                DgvData.DataSource = null;
                DgvData.DataSource = listar.OrderByDescending(p => p.datas).ToList();
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
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "fabrica", "datas", "entrada", });
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
        private void Liberarbotao(bool hab)
        {
            BtnSalvarMaterial.Enabled = hab;
        }
        private itensdata lerdata()
        {
            try
            {
                var iten = new itensdata();
                int id = 0;
                int.TryParse(TxtData.Text, out id);
                if (id == 0)
                {
                    iten.datas = DtData.Value;
                    iten.fabrica = TxtFabrica.Text;
                    iten.entrada = Convert.ToDecimal(TxtEntrada.Text);
                    iten.idmadeiras = Convert.ToInt32(TxtIdmadeira.Text);
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
        private void Limparcampos()
        {
            TxtIdmadeira.Text = Convert.ToString(null);
            TxtFabrica.Text = Convert.ToString(null);
            TxtMadeiras.Text = Convert.ToString(null);
            TxtUnidadeMedida.Text = Convert.ToString("m²");
            TxtEntrada.Text = Convert.ToString(0);
            TxtTotal.Text = Convert.ToString(null);
            TxtTotal1.Text = Convert.ToString(0);
            TxtData.Text = Convert.ToString(0);
        }
        private void DgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                #region Tab1
                var prop = new madeira();
                prop.idmadeiras = Convert.ToInt32(DgvMaterial.Rows[e.RowIndex].Cells[0].Value);
                _madeira = prop;
                #endregion            
                EscolherCores();
                HabilitarCampos(true);
                carregardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }       
        }

        private void EscolherCores()
        {
            if (_madeira == null)
                _madeira = new madeira();
            if (_madeira.idmadeiras > 0)
            { 
                #region Codigos
                _madeira = new DLmadeira().ConsultarPorId(_madeira.idmadeiras);
                #region Carregar Tela de Atualizar
                TxtIdmadeira.Text = _madeira.idmadeiras.ToString();
                TxtFabrica.Text = _madeira.fabrica;
                TxtMadeiras.Text = _madeira.madeiras;
                TxtUnidadeMedida.Text = _madeira.unidademedida;
                TxtTotal1.Text = Convert.ToString(_madeira.total);
                TxtTotal.Text = Convert.ToString(_madeira.total);
                #endregion
                #region Carregar Tela de Saida
                Txtcodigo.Text = Convert.ToString(_madeira.codigo);
                TxtMadeiraSaida.Text = _madeira.madeiras;
                TxtMedidaSaida.Text = _madeira.unidademedida;
                TxtSaida2.Text = Convert.ToString(_madeira.total);
               
                #endregion

                #endregion
                switch (_madeira.statusobraid)//escolha
                {
                    case 1:
                        {
                            RbEngenharia.Checked = true;
                        }
                        break;
                    case 2:
                        {
                            RbComercio.Checked = true;
                        }
                        break;
                    case 3:
                        {
                            RbPisos.Checked = true;
                        }
                        break;                 
                }               
            }
            else
            {
                RbComercio.Checked = true;
            }
        }

        private void DgvMaterial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvMaterial.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvMaterial.Rows[i].Cells[19].Value);
                switch (valor)
                {
                    case "1": DgvMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "2": DgvMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "3": DgvMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            CalcularSaida();
        }
        private void CalcularSaida()
        {
            try
            {
                int id = 0;
                int.TryParse(TxtSaida.Text, out id);
                if (id > 0)
                {
                    saidadematerial();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void saidadematerial()
        {
            try
            {
                decimal saida = 0;
                decimal saida2 = 0;
                decimal total = 0;
                if (decimal.TryParse(TxtSaida.Text, out saida))
                {
                    if (decimal.TryParse(TxtSaida2.Text, out saida2))
                    {
                        total = saida2 - saida;
                    }
                }
                TxtTotalSaida.Text = total.ToString("N2");
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
                decimal entrada = 0;
                decimal total = 0;
                decimal total2 = 0;
                if (decimal.TryParse(TxtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(TxtTotal1.Text, out total))
                    {
                        total2 = entrada + total;
                    }
                    TxtTotal.Text = total2.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idmadeira = Convert.ToInt32(Txtcodigo.Text);
                    madeirass = TxtMadeiraSaida.Text;
                    medida = TxtMedidaSaida.Text;
                    total = Convert.ToDecimal(TxtSaida.Text);
                    int id = 0;
                    int.TryParse(Txtcodigo.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLmadeira().ConsultarPorId(id);
                        madeiraAt.total = Convert.ToDecimal(TxtTotalSaida.Text);
                        new DLmadeira().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
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
            Txtcodigo.Text = Convert.ToString(null);
            TxtMadeiraSaida.Text = Convert.ToString(null);
            TxtMedidaSaida.Text = Convert.ToString(null);
            TxtSaida.Text = Convert.ToString(null);
            TxtSaida2.Text = Convert.ToString(null);
            TxtTotalSaida.Text = Convert.ToString(null);
            TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
            Carregargrid();
        }
        private void BtnSalvarData_Click(object sender, EventArgs e)
        {
            try
            {
                var itenproposta = lerdata();
                int ItensPropostaId = 0;
                if (TxtData.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtData.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtIdmadeira.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtIdmadeira.Text);
                }
                var listarmadeira = new DLitensdata().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.idmadeiras == propostaid //por proppostaid
                                && ip.iddatas == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.iddatas > 0)
                {
                    prop.iddatas = Convert.ToInt32(TxtData.Text);
                    prop.datas = DtData.Value;
                    prop.fabrica = TxtFabrica.Text;
                    prop.entrada = Convert.ToDecimal(TxtEntrada.Text);
                    new DLitensdata().Atualizar(prop);
                }
                else
                {
                    new DLitensdata().Inserir(itenproposta);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }
                Liberarbotao(true);
                TxtEntrada.Text = Convert.ToString(0);
                TxtData.Text = Convert.ToString(0);
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
                    int.TryParse(TxtIdmadeira.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLmadeira().ConsultarPorId(id);
                        madeiraAt.idmadeiras = Convert.ToInt32(TxtIdmadeira.Text);
                        madeiraAt.fabrica = TxtFabrica.Text;
                        madeiraAt.madeiras = TxtMadeiras.Text;
                        madeiraAt.unidademedida = TxtUnidadeMedida.Text;
                        madeiraAt.entrada = Convert.ToDecimal(TxtEntrada.Text);
                        madeiraAt.total = Convert.ToDecimal(TxtTotal.Text);

                        if (RbEngenharia.Checked == true)
                            madeiraAt.statusobraid = 1;

                        else if (RbComercio.Checked == true)
                            madeiraAt.statusobraid = 2;

                        else if (RbPisos.Checked == true)
                            madeiraAt.statusobraid = 3;

                        new DLmadeira().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        Limparcampos();
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
                    int.TryParse(TxtData.Text, out id);
                    if (id > 0)
                    {
                        new DLitensdata().Excluir(new itensdata { iddatas = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        TxtData.Text = Convert.ToString(null);
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
                    int.TryParse(TxtIdmadeira.Text, out id);
                    if (id > 0)
                    {
                        new DLmadeira().Excluir(new madeira { idmadeiras = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        Carregargrid();
                        Limparcampos();
                        TxtIdmadeira.Text = Convert.ToString(null);
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
                var madeiras = new madeira();
                madeiras.statusobraid = 2;//Pendente
                var id = new DLmadeira().Inserir(madeiras);//inserir
                TxtIdmadeira.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TxtData.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[0].Value);
            DtData.Value = Convert.ToDateTime(DgvData.Rows[e.RowIndex].Cells[2].Value);
            TxtEntrada.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[3].Value);

        }
        private void BtnLimparTudo_Click_1(object sender, EventArgs e)
        {
            Limparcampos();
            TxtData.Text = Convert.ToString(null);
            DgvData.DataSource = null;

        }
        private void TxtTotal1_TextChanged_1(object sender, EventArgs e)
        {
            CalcularEntrada();
        }
        private void TxtPesquisar_Click_1(object sender, EventArgs e)
        {
            TxtPesquisar.Clear();
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(DgvMaterial);
        }
        private void TxtSaida_Click(object sender, EventArgs e)
        {
            TxtSaida.Clear();
        }
        private void TxtSaida_TextChanged_1(object sender, EventArgs e)
        {
            CalcularSaida();
        }
    }
}
