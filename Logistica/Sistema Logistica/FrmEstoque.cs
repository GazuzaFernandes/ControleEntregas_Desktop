using DALLogistica.Entities;
using DALLogistica.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Sistema_Logistica
{
    public partial class FrmEstoque : Form
    {
        public int materialId;
        public string Material, UndMedida, QtdSaida, QtdCaixa;
        public FrmEstoque()
        {
            InitializeComponent();
        }
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGridSaida();
                HabilitarCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Metodos
        private void HabilitarCampos(bool habilitar)
        {
            txtFabrica.Enabled = habilitar;
            txtMaterial.Enabled = habilitar;
            txtQuantidadeCaixa.Enabled = habilitar;
            txtEntrada.Enabled = habilitar;
            txtUnidadeMedida.Enabled = habilitar;
            btnSalvarData.Enabled = habilitar;
            btnSalvarMaterial.Enabled = habilitar;
            btnDeletarMaterial.Enabled = habilitar;
            btnDeletarData.Enabled = habilitar;
            btnLimparTudo.Enabled = habilitar;
            txtCalcularSaida.Enabled = habilitar;
            btnSelecionar.Enabled = habilitar;
            btnLimparMaterial.Enabled = habilitar;
        }
        private void CarregarGridSaida(bool isPesquisa = false)
        {
            try
            {
                var listaEstoque = new DLItensMaterial().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisaMaterial.Text.ToLower();
                    listaEstoque = listaEstoque.Where(p => p.Material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvMaterial.DataSource = listaEstoque.OrderBy(p => p.Material).ToList();
                MontarGridSaida(DgvMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridSaida(DataGridView DgvMaterial)
        {
            try
            {
                DgvMaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "UnidadeMedida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Unidade de Medida", "Estoque", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 30, 30, 33 }, DgvMaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarGridData()
        {
            try
            {
                var listaDataMaterial = new DLDataMaterial().Listar().Where(p => p.MaterialId == Convert.ToInt32(txtMaterialId.Text)).ToList();
                DgvData.DataSource = null;
                DgvData.DataSource = listaDataMaterial.OrderByDescending(p => p.DataEntrada).ToList(); ;
                DgvData.Refresh();
                MontarGridCadastro(DgvData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridCadastro(DataGridView dgvData)
        {
            try
            {
                DgvData.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "DataEntrada", "Entrada", "Fabrica", "Obra", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data de Entrada", "Quantidade de Entrada", "Fabrica", "Devolução" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20, 20, 30 }, DgvData.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataMaterial LerData()
        {
            try
            {
                var data = new DataMaterial();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    data.DataEntrada = dtpData.Value;
                    data.Fabrica = txtFabrica.Text;
                    data.Obra = txtDevolucao.Text;
                    data.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    data.MaterialId = Convert.ToInt32(txtMaterialId.Text);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularCadastro()
        {
            try
            {
                #region Calcular Quantidade de Caixa no pedido
                decimal pacote = 0, entrada = 0, caixas = 0;
                if (decimal.TryParse(txtQuantidadeCaixa.Text, out pacote))
                {
                    if (decimal.TryParse(txtEntrada.Text, out entrada))
                    {
                        caixas = entrada / pacote;
                    }
                    txtTotalCaixas.Text = caixas.ToString("N2");
                }
                #endregion

                #region Calcular Entrada de Estoque
                decimal entradaa = 0, soma = 0, total = 0;
                if (decimal.TryParse(txtEntrada.Text, out entradaa))
                {
                    if (decimal.TryParse(txtSomaEntrada.Text, out soma))
                    {
                        total = entradaa + soma;
                    }
                    txtTotal.Text = total.ToString("N2");
                }
                #endregion

                #region Calcular Quantidade no Pacote
                decimal pacotee = 0, somaa = 0, totall = 0;
                if (decimal.TryParse(txtQuantidadeCaixa.Text, out pacotee))
                {
                    if (decimal.TryParse(txtTotal.Text, out somaa))
                    {
                        totall = somaa / pacotee;
                    }
                    txtTotalCaixas.Text = total.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimparCadastro()
        {
            try
            {
                txtFabrica.Text = Convert.ToString(null);
                txtMaterialId.Text = Convert.ToString(null);
                txtDataId.Text = Convert.ToString(null);
                txtMaterial.Text = Convert.ToString(null);
                txtQuantidadeCaixa.Text = Convert.ToString("1");
                txtTotalCaixas.Text = Convert.ToString("0");
                txtEntrada.Text = Convert.ToString("0");
                txtSomaEntrada.Text = Convert.ToString("0");
                txtTotal.Text = Convert.ToString("0");
                txtUnidadeMedida.Text = Convert.ToString("Kg");
                txtDevolucao.Text = Convert.ToString(null);
                DgvData.DataSource = null;
                HabilitarCampos(false);
                CarregarGridSaida();
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
        private void LimparSaidaMaterial()
        {
            txtCodigoMaterial.Text = Convert.ToString(null);
            txtCalcularSaida.Text = Convert.ToString(null);
            txtEstoqueAtualSaida.Text = Convert.ToString(null);
            txtEstoqueSaida.Text = Convert.ToString(null);
            txtSaidaQuantidadeCaixa.Text = Convert.ToString(null);
            txtMedidaSaida.Text = Convert.ToString(null);
            txtMadeiraSaida.Text = Convert.ToString(null);
            txtPesquisaMaterial.Text = Convert.ToString("Digite para pesquisar");
            CarregarGridSaida();
        }
        private void CadastrarSaida()
        {
            try
            {
                #region Estoque Entrada
                decimal saida = 0, subtracao = 0, total = 0;
                if (decimal.TryParse(txtCalcularSaida.Text, out saida))
                {
                    if (decimal.TryParse(txtEstoqueAtualSaida.Text, out subtracao))
                    {
                        total = subtracao - saida;
                    }
                    txtEstoqueSaida.Text = total.ToString("N2");
                }
                #endregion

                #region Estoque Saida
                decimal saidaa = 0, subtracaoo = 0, totall = 0;
                if (decimal.TryParse(txtCalcularSaida.Text, out saidaa))
                {
                    if (decimal.TryParse(txtEstoqueAtualSaida.Text, out subtracaoo))
                    {
                        totall = subtracao - saida;
                    }
                    txtEstoqueSaida.Text = total.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Tela Saida do Material
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja  Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    materialId = Convert.ToInt32(txtCodigoMaterial.Text);
                    Material = txtMadeiraSaida.Text;
                    UndMedida = txtMedidaSaida.Text;
                    QtdSaida = txtCalcularSaida.Text;

                    int id = 0;
                    int.TryParse(txtCodigoMaterial.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                        madeiraAt.Total = Convert.ToDecimal(txtEstoqueSaida.Text);
                        new DLItensMaterial().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                    }
                    LimparSaidaMaterial();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimparMaterial_Click(object sender, EventArgs e)
        {
            LimparSaidaMaterial();
        }
        private void TxtPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            CarregarGridSaida(true);
            MontarGridSaida(DgvMaterial);
        }
        private void DgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var material = DgvMaterial.Rows[e.RowIndex].DataBoundItem as ItensMaterial;
                if (material != null)
                {
                    #region Tela de Cadastro de Material
                    txtMaterialId.Text = material.MaterialId.ToString();
                    txtMaterial.Text = material.Material;
                    txtUnidadeMedida.Text = material.UnidadeMedida;
                    txtQuantidadeCaixa.Text = Convert.ToString(material.Quantidade);
                    txtSomaEntrada.Text = Convert.ToString(material.Entrada);
                    txtTotal.Text = Convert.ToString(material.Total);
                    #endregion

                    #region Tela de Saida de Material
                    txtCodigoMaterial.Text = material.MaterialId.ToString();
                    txtMadeiraSaida.Text = material.Material;
                    txtMedidaSaida.Text = material.UnidadeMedida;
                    txtEstoqueAtualSaida.Text = Convert.ToString(material.Total);
                    txtSaidaQuantidadeCaixa.Text = Convert.ToString(material.Quantidade);
                    #endregion
                }
                HabilitarCampos(true);
                CarregarGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void TxtPesquisaMaterial_Click(object sender, EventArgs e)
        {
            txtPesquisaMaterial.Clear();
        }
        private void TxtSaida_TextChanged(object sender, EventArgs e)
        {
            CadastrarSaida();
        }
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            CadastrarSaida();
        }
        #endregion

        #region Tela Cadastro de Material
        private void BtnGerarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var itens = new ItensMaterial();
                var id = new DLItensMaterial().Inserir(itens);//inserir
                txtMaterialId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvarData_Click(object sender, EventArgs e)
        {
            try
            {
                var dataMaterial = LerData();
                int dataId = 0;
                if (txtDataId.Text != "")
                {
                    dataId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int estoqueId = 0;
                if (txtMaterialId.Text != "")
                {
                    estoqueId = Convert.ToInt32(txtMaterialId.Text);
                }
                var listarmadeira = new DLDataMaterial().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.MaterialId == estoqueId //por proppostaid
                                && ip.DataId == dataId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.DataId > 0)
                {
                    prop.DataId = Convert.ToInt32(txtDataId.Text);
                    prop.DataEntrada = dtpData.Value;
                    prop.Fabrica = txtFabrica.Text;
                    prop.Obra = txtDevolucao.Text;
                    prop.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    new DLDataMaterial().Atualizar(prop);
                }
                else
                {
                    new DLDataMaterial().Inserir(dataMaterial);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }
                txtDataId.Text = Convert.ToString(null);
                CarregarGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularCadastro();
        }
        private void TxtQuantidadeCaixa_TextChanged(object sender, EventArgs e)
        {
            CalcularCadastro();
        }
        private void TxtSomaEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularCadastro();
        }
        private void BtnDeletarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse Produto ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtMaterialId.Text, out id);
                    if (id > 0)
                    {
                        new DLItensMaterial().Excluir(new ItensMaterial { MaterialId = id });
                        MessageBox.Show("Material excluído com sucesso!");
                        txtDataId.Text = Convert.ToString(null);
                        CarregarGridSaida();
                        LimparCadastro();
                        HabilitarCampos(false);

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
        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }
        private void BtnSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtMaterialId.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                        madeiraAt.MaterialId = Convert.ToInt32(txtMaterialId.Text);
                        madeiraAt.Material = txtMaterial.Text;
                        madeiraAt.UnidadeMedida = txtUnidadeMedida.Text;
                        madeiraAt.Total = Convert.ToDecimal(txtTotal.Text);
                        madeiraAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                        madeiraAt.Quantidade = Convert.ToDecimal(txtQuantidadeCaixa.Text); //quantidade de caixas
                        new DLItensMaterial().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        CarregarGridSaida();
                        DgvData.DataSource = null;
                        LimparCadastro();
                        HabilitarCampos(false);
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
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtDataId.Text, out id);
                    if (id > 0)
                    {
                        new DLDataMaterial().Excluir(new DataMaterial { DataId = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        LimparCadastro();
                        txtDataId.Text = Convert.ToString(null);
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
        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = DgvData.Rows[e.RowIndex].DataBoundItem as DataMaterial;
            if (data != null)
            {
                txtDataId.Text = data.DataId.ToString();
                dtpData.Value = data.DataEntrada;
                txtFabrica.Text = data.Fabrica;
                txtEntrada.Text = Convert.ToString(data.Entrada);
                txtDevolucao.Text = data.Obra;
            }
        }
        #endregion
    }
}
