using DALLogistica.Entities;
using DALLogistica.Repository;
using DALSenhas.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_Logistica
{
    public partial class FrmSaidaEstoque : Form
    {
        public FrmSaidaEstoque()
        {
            InitializeComponent();
        }
        private void FrmSaidaEstoque_Load(object sender, EventArgs e)
        {
            var listaProposta = new DLControle().Listar();
            CarregarControle();
            HabilitarBotao(false);
        }
        private void CarregarMaterial()
        {
            ListarGridData();           
        }
        private void ListarGridData()
        {
            try
            {
                var lstitensproposta = new DLItenControle().Listar().Where(p => p.controleid == Convert.ToInt32(TxtIdObra.Text)).ToList();
                DgvSaida.DataSource = null;
                DgvSaida.DataSource = lstitensproposta;
                DgvSaida.Refresh(); MontarMaterial(DgvSaida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarMaterial(DataGridView dgvSaida)
        {
            try
            {
                DgvSaida.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvSaida);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "material", "undmedida", "qtdcaixas", "qtdsaida", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Unidade Medida", "Qtd Saida", "Qtd Caixa" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 35, 20, 20, 20 }, DgvSaida.Width - 15); //O total tem que ficar em 100% 
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
        private void CarregarControle(bool isPesquisa = false)
        {
            try
            {
                var controless = new DLControle().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisarSaida.Text.ToLower();

                    if (RbPesquisa.Checked)
                        controless = controless.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                }
                DgvEstoqueObra.DataSource = controless.OrderByDescending(p => p.dataentrada).ToList();
                MontarControle(DgvEstoqueObra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarControle(DataGridView dgvEstoqueObra)
        {
            try
            {
                DgvEstoqueObra.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvEstoqueObra);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "dataentrada", "proposta", "obra", "funcionario" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data de Saida", "Proposta", "Obra", "Funcionario na Obra" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20, 35, 20 }, DgvEstoqueObra.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtIdObra.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLControle().ConsultarPorId(id);
                        pAtua.dataentrada = DtData.Value;
                        pAtua.proposta = TxtProposta.Text;
                        pAtua.obra = TxtObra.Text;
                        pAtua.funcionario = TxtFuncionario.Text;
                        new DLControle().Atualizar(pAtua);
                        MessageBox.Show("Saida Atualizada com Sucesso!");
                        LimparInformacaoObra();
                        CarregarControle();
                        HabilitarBotao(false);
                        BloquearBotao(true);
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
        private void BtnDeletarObra_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLSenha().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].senhass == login.TxtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(TxtIdObra.Text, out id);
                        if (id > 0)
                        {
                            new DLControle().Excluir(new Controle { controleid = id });
                            MessageBox.Show("Proposta excluída com sucesso!");
                            LimparInformacaoObra();
                            HabilitarBotao(false);
                        }
                    }                  
                    else
                    {                        
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
            LimparInformacaoObra();
            HabilitarBotao(false);
        }
        private void LimparInformacaoObra()
        {
            TxtPesquisarSaida.Text = Convert.ToString("Digite para pesquisar");
            TxtProposta.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            TxtFuncionario.Text = Convert.ToString(null);
            TxtIdObra.Text = Convert.ToString(null);
            DgvSaida.DataSource = null;
            CarregarControle();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoque estoque = new FrmEstoque();
                estoque.ShowDialog();
                var materialId = estoque.materialId;
                var Material = estoque.Material;
                var UndMedida = estoque.UndMedida;
                var QtdSaida = estoque.QtdSaida;
                TxtCodigoInfomacao.Text = materialId.ToString();
                TxtMaterialSaida.Text = Material;
                TxtUndMedida.Text = UndMedida;
                TxtQtd.Text = QtdSaida;
                estoque.Close();
                estoque.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var itencontrole = lercampos();
                int ItensPropostaId = 0;
                if (TxtIdSaida.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtIdSaida.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtIdObra.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtIdObra.Text);
                }
                var listaProposta = new DLItenControle().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.controleid == propostaid //por proppostaid
                                && ip.itencontroleid == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.itencontroleid > 0)
                {
                    prop.codigo = Convert.ToInt32(TxtCodigoInfomacao.Text);
                    prop.material = TxtMaterialSaida.Text;
                    prop.undmedida = TxtUndMedida.Text;
                    prop.qtdcaixas = Convert.ToDecimal(TxtQtd.Text);
                    prop.qtdsaida = Convert.ToDecimal(TxtQtdCaixas.Text);
                    new DLItenControle().Atualizar(prop);
                }
                else
                {
                    new DLItenControle().Inserir(itencontrole);
                    MessageBox.Show("Item Cadastrado com Sucesso");
                }
                LimparCamposItens();
                CarregarMaterial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCamposItens()
        {
            TxtIdSaida.Text = Convert.ToString(null);
            TxtCodigoInfomacao.Text = Convert.ToString(null);
            TxtMaterialSaida.Text = Convert.ToString("Nome do Item");
            TxtUndMedida.Text = Convert.ToString("m²");
            TxtQtd.Text = Convert.ToString(0);
            TxtQtdCaixas.Text = Convert.ToString(0);           
        }
        private ItenControle lercampos()
        {
            try
            {
                var iten = new ItenControle();
                int id = 0;
                int.TryParse(TxtIdSaida.Text, out id);
                if (id == 0)
                {
                    iten.codigo = Convert.ToInt32(TxtCodigoInfomacao.Text);
                    iten.material = TxtMaterialSaida.Text;
                    iten.undmedida = TxtUndMedida.Text;
                    iten.qtdcaixas = Convert.ToDecimal(TxtQtd.Text);
                    iten.qtdsaida = Convert.ToDecimal(TxtQtdCaixas.Text);
                    iten.controleid = Convert.ToInt32(TxtIdObra.Text);
                }
                return iten;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(TxtIdSaida.Text, out id);
                if (id > 0)
                {
                    var prop = new DLItenControle().ConsultarPorId(id);
                    if (prop.itencontroleid > 0)
                    {
                        new DLItenControle().Excluir(prop);
                        CarregarMaterial(); LimparCamposItens();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o item da proposta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnLimparInformacao_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
        }
        private void TxtPesquisarSaida_Click(object sender, EventArgs e)
        {
            TxtPesquisarSaida.Clear();
        }
        private void TxtPesquisarSaida_TextChanged(object sender, EventArgs e)
        {
            CarregarControle(true);
            MontarControle(DgvEstoqueObra);
        }
        private void BtnCriarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                var proposta = new Controle();
                var id = new DLControle().Inserir(proposta);//inserir
                TxtIdObra.Text = id.ToString();
                HabilitarBotao(true);
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BloquearBotao(bool travar)
        {
            BtnCriarProposta.Enabled = travar;
        }
        private void HabilitarBotao(bool hab)
        {
            TxtProposta.Enabled = hab;
            BtnPesquisar.Enabled = hab;
            TxtObra.Enabled = hab;
            Btnsalvar.Enabled = hab;
            BtnDeletarObra.Enabled = hab;           
            BtnInserir.Enabled = hab;
            BtnApagar.Enabled = hab;
            TxtObra.Enabled = hab;
            TxtFuncionario.Enabled = hab;
        }
        private void DgvSaida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdSaida.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[0].Value);
                TxtCodigoInfomacao.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[1].Value);
                TxtMaterialSaida.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[2].Value);
                TxtUndMedida.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[3].Value);
                TxtQtd.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[4].Value);
                TxtQtdCaixas.Text = Convert.ToString(DgvSaida.Rows[e.RowIndex].Cells[5].Value);
                HabilitarBotao(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvEstoqueObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdObra.Text = Convert.ToString(DgvEstoqueObra.Rows[e.RowIndex].Cells[0].Value);
                TxtProposta.Text = Convert.ToString(DgvEstoqueObra.Rows[e.RowIndex].Cells[2].Value);
                TxtObra.Text = Convert.ToString(DgvEstoqueObra.Rows[e.RowIndex].Cells[3].Value);
                TxtFuncionario.Text = Convert.ToString(DgvEstoqueObra.Rows[e.RowIndex].Cells[4].Value);
                HabilitarBotao(true);
                ListarGridData();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }          
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque();
            estoque.ShowDialog();
        }
    }
}
