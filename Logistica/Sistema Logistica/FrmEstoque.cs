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
                CarregarSaida();
                HabilitarCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void HabilitarCampos(bool habilitar)
        {
            TxtFabrica.Enabled = habilitar;
            TxtMaterial.Enabled = habilitar;
            TxtQuantidadeCaixa.Enabled = habilitar;
            TxtEntrada.Enabled = habilitar;
            TxtUnidadeMedida.Enabled = habilitar;
            BtnSalvarData.Enabled = habilitar;
            BtnSalvarMaterial.Enabled = habilitar;
            BtnDeletarMaterial.Enabled = habilitar;
            BtnDeletarData.Enabled = habilitar;
            BtnLimparTudo.Enabled = habilitar;
            TxtSaida.Enabled = habilitar;
            BtnSelecionar.Enabled = habilitar;
            BtnLimparMaterial.Enabled = habilitar;
        }
        private void CarregarSaida(bool isPesquisa = false)
        {
            try
            {
                var listaEstoque = new DLItensMaterial().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisaMaterial.Text.ToLower();
                    listaEstoque = listaEstoque.Where(p => p.material.ToLower().Contains(pesquisa)).ToList();
                }
                DgvMaterial.DataSource = listaEstoque.OrderBy(p => p.material).ToList(); 
                MontarSaida(DgvMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }    
        }
        private void MontarSaida(DataGridView DgvMaterial)
        {
            try
            {
                DgvMaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "material", "unidademedida", "total", });
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
        private void CarregarData()
        {
            try
            {
                var listaDataMaterial = new DLDataMaterial().Listar().Where(p => p.materialid == Convert.ToInt32(TxtIdMaterial.Text)).ToList();
                DgvData.DataSource = null;
                DgvData.DataSource = listaDataMaterial.OrderByDescending(p => p.dataentrada).ToList(); ;
                DgvData.Refresh();
                MontarCadastro(DgvData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarCadastro(DataGridView dgvData)
        {
            try
            {
                DgvData.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "dataentrada", "entrada", "fabrica", "obra",});
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
        private void BtnGerarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var itens = new ItensMaterial();
                var id = new DLItensMaterial().Inserir(itens);//inserir
                TxtIdMaterial.Text = id.ToString();
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
                var itenEstoque = lerdata();
                int ItensPropostaId = 0;
                if (TxtData.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtData.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtIdMaterial.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtIdMaterial.Text);
                }
                var listarmadeira = new DLDataMaterial().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.materialid == propostaid //por proppostaid
                                && ip.dataid == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.dataid > 0)
                {
                    prop.dataid = Convert.ToInt32(TxtData.Text);
                    prop.dataentrada = DtData.Value;
                    prop.fabrica = TxtFabrica.Text;
                    prop.obra = TxtDevolucao.Text;
                    prop.entrada = Convert.ToDecimal(TxtEntrada.Text);
                    new DLDataMaterial().Atualizar(prop);
                }
                else
                {
                    new DLDataMaterial().Inserir(itenEstoque);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }

                TxtEntrada.Text = Convert.ToString(0);
                TxtData.Text = Convert.ToString(null);
                CarregarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private DataMaterial lerdata()
        {
            try
            {
                var iten = new DataMaterial();
                int id = 0;
                int.TryParse(TxtData.Text, out id);
                if (id == 0)
                {
                    iten.dataentrada = DtData.Value;
                    iten.fabrica = TxtFabrica.Text;
                    iten.obra = TxtDevolucao.Text;
                    iten.entrada = Convert.ToDecimal(TxtEntrada.Text);
                    iten.materialid = Convert.ToInt32(TxtIdMaterial.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnDeletarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse Produto ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtIdMaterial.Text, out id);
                    if (id > 0)
                    {
                        new DLItensMaterial().Excluir(new ItensMaterial { materialid = id });
                        MessageBox.Show("Material excluído com sucesso!");
                        TxtData.Text = Convert.ToString(null);
                        CarregarSaida();
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
        private void LimparCadastro()
        {
            try
            {
                TxtFabrica.Text = Convert.ToString(null);
                TxtIdMaterial.Text = Convert.ToString(null);
                TxtData.Text = Convert.ToString(null);
                TxtMaterial.Text = Convert.ToString(null);
                TxtQuantidadeCaixa.Text = Convert.ToString("1");                
                TxtTotalCaixas.Text = Convert.ToString("0");
                TxtEntrada.Text = Convert.ToString("0");
                TxtSomaEntrada.Text = Convert.ToString("0");
                TxtTotal.Text = Convert.ToString("0");
                TxtUnidadeMedida.Text = Convert.ToString("Kg");
                TxtDevolucao.Text = Convert.ToString(null);
                DgvData.DataSource = null;
                HabilitarCampos(false);
                CarregarSaida();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtIdMaterial.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                        madeiraAt.materialid = Convert.ToInt32(TxtIdMaterial.Text);
                        madeiraAt.material = TxtMaterial.Text;
                        madeiraAt.unidademedida = TxtUnidadeMedida.Text;
                        madeiraAt.total = Convert.ToDecimal(TxtTotal.Text);
                        madeiraAt.entrada = Convert.ToDecimal(TxtEntrada.Text);
                        madeiraAt.quantidade = Convert.ToDecimal(TxtQuantidadeCaixa.Text); //quantidade de caixas
                        new DLItensMaterial().Atualizar(madeiraAt);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        CarregarSaida();
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
        private bool Validarcampos()
        {
            return true;
        }
        private void BtnDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtData.Text, out id);
                    if (id > 0)
                    {
                        new DLDataMaterial().Excluir(new DataMaterial { dataid = id });
                        MessageBox.Show("Madeira excluída com sucesso!");                        
                        LimparCadastro();
                        TxtData.Text = Convert.ToString(null);
                      //CarregarData();
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
        private void CalcularCadastro()
        {
            try
            {
                decimal pacote = 0, entrada = 0, caixas = 0;        
                if (decimal.TryParse(TxtQuantidadeCaixa.Text, out pacote))
                {
                    if (decimal.TryParse(TxtEntrada.Text, out entrada))
                    {
                        caixas = entrada / pacote;
                    }
                    TxtTotalCaixas.Text = caixas.ToString("N2");
                }

                decimal entradaa = 0, soma = 0, total = 0;               
                if (decimal.TryParse(TxtEntrada.Text, out entradaa))
                {
                    if (decimal.TryParse(TxtSomaEntrada.Text, out soma))
                    {
                        total = entradaa + soma;
                    }
                    TxtTotal.Text = total.ToString("N2");
                }

                decimal pacotee = 0, somaa = 0, totall = 0;               
                if (decimal.TryParse(TxtQuantidadeCaixa.Text, out pacotee))
                {
                    if (decimal.TryParse(TxtTotal.Text, out somaa))
                    {
                        totall = somaa / pacotee;
                    }
                    TxtTotalCaixas.Text = total.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtData.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[0].Value);
            DtData.Value = Convert.ToDateTime(DgvData.Rows[e.RowIndex].Cells[1].Value);
            TxtFabrica.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[3].Value);
            TxtEntrada.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[2].Value);
            TxtDevolucao.Text = Convert.ToString(DgvData.Rows[e.RowIndex].Cells[4].Value);
        }        
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja  Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    materialId = Convert.ToInt32(TxtcodigoMaterial.Text);
                    Material = TxtMadeiraSaida.Text;
                    UndMedida = TxtMedidaSaida.Text;
                    QtdSaida = TxtSaida.Text;                   
                    
                    int id = 0;
                    int.TryParse(TxtcodigoMaterial.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                        madeiraAt.total = Convert.ToDecimal(TxtTotalSaida.Text);
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
        private void LimparSaidaMaterial()
        {
            TxtcodigoMaterial.Text = Convert.ToString(null);
            TxtSaida.Text = Convert.ToString(null);
            TxtSaida2.Text = Convert.ToString(null);
            TxtTotalSaida.Text = Convert.ToString(null);
            TxtSaidaQuantidadeCaixa.Text = Convert.ToString(null);
            TxtMedidaSaida.Text = Convert.ToString(null);
            TxtMadeiraSaida.Text = Convert.ToString(null);
            TxtPesquisaMaterial.Text = Convert.ToString("Digite para pesquisar");
            CarregarSaida();
        }
        private void BtnLimparMaterial_Click(object sender, EventArgs e)
        {
            LimparSaidaMaterial();
        }
        private void TxtPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            CarregarSaida(true);
            MontarSaida(DgvMaterial);
        }
        private void TxtPesquisaMaterial_Click(object sender, EventArgs e)
        {
            TxtPesquisaMaterial.Clear();
        }
        private void TxtSaida_TextChanged(object sender, EventArgs e)
        {
            CadastrarSaida();
        }
        private void TxtSaida2_TextChanged(object sender, EventArgs e)
        {
            CadastrarSaida();
        }
        private void CadastrarSaida()
        {
            try
            {
                #region EstoqueEntrada
                decimal saida = 0, subtracao = 0, total = 0;
                if (decimal.TryParse(TxtSaida.Text, out saida))
                {
                    if (decimal.TryParse(TxtSaida2.Text, out subtracao))
                    {
                        total = subtracao - saida;
                    }
                    TxtTotalSaida.Text = total.ToString("N2");
                }
                #endregion
                #region EstoqueSaida
                decimal saidaa = 0, subtracaoo = 0, totall = 0;                
                if (decimal.TryParse(TxtSaida.Text, out saidaa))
                {
                    if (decimal.TryParse(TxtSaida2.Text, out subtracaoo))
                    {
                        totall = subtracao - saida;
                    }
                    TxtTotalSaida.Text = total.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                #region Cadastro
                TxtIdMaterial.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[0].Value);
                TxtMaterial.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[1].Value);
                TxtUnidadeMedida.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[2].Value);
                TxtQuantidadeCaixa.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[5].Value);
                TxtSomaEntrada.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[3].Value);
                TxtTotal.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[3].Value);
                #endregion
                #region Saida
                TxtcodigoMaterial.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[0].Value);
                TxtMadeiraSaida.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[1].Value);
                TxtMedidaSaida.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[2].Value);
                TxtSaida2.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[3].Value);
                TxtSaidaQuantidadeCaixa.Text = Convert.ToString(DgvMaterial.Rows[e.RowIndex].Cells[5].Value);
                #endregion
                HabilitarCampos(true);
                CarregarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
