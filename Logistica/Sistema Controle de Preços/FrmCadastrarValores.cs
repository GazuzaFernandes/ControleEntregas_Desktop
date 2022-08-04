using DALOrcamento.Entities;
using DALOrcamento.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_Controle_de_Preços
{
    public partial class FrmCadastrarValores : Form
    {
        internal produtos _produto;
        public FrmCadastrarValores()
        {
            InitializeComponent();
        }
        private void FrmCadastrarValores_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                if (_produto == null)
                    _produto = new produtos();
                if (_produto.produtoid > 0)
                {
                    HabilitarCampos(true);
                    _produto = new DLprodutos().ConsultarPorId(_produto.produtoid);
                    TxtIdProduto.Text = _produto.produtoid.ToString();                    
                    TxtFonrcedor.Text = _produto.fornecedor;
                    TxtPreco.Text = _produto.preco;
                    TxtProduto.Text = _produto.produto;
                    TxtRendimento.Text = _produto.rendimento;
                    RtbComentario.Text = _produto.comentario;
                   Carregargrid();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void Carregargrid()
        {
            try
            {
                var listar = new DLdataproduto().Listar().Where(p => p.produtoid == Convert.ToInt32(TxtIdProduto.Text)).ToList();
                DgvDatas.DataSource = null;
                DgvDatas.DataSource = listar.OrderByDescending(p => p.data).ToList();
                DgvDatas.Refresh(); Montardata(DgvDatas);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Montardata(object dgvDatas)
        {
            DgvDatas.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvDatas);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() {  "data", "preco" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data da Atualização", "Valor" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() {  40, 40, }, DgvDatas.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }      
        private dataproduto lerdata()
        {
            try
            {
                var iten = new dataproduto();
                int id = 0;
                int.TryParse(TxtIdData.Text, out id);
                if (id == 0)
                {
                    iten.data = DtpAtualizado.Value;
                    iten.preco = TxtPreco.Text;
                    iten.produtoid = Convert.ToInt32(TxtIdProduto.Text);
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
            TxtFonrcedor.Text = Convert.ToString(null);
            TxtIdData.Text = Convert.ToString(null);
            TxtIdProduto.Text = Convert.ToString(null);
            TxtPreco.Text = Convert.ToString(null);
            TxtProduto.Text = Convert.ToString(null);
            TxtRendimento.Text = Convert.ToString(null);
            RtbComentario.Text = Convert.ToString(null);
        }     
        private void BtnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var produtos = new produtos();
                var id = new DLprodutos().Inserir(produtos);//inserir
                TxtIdProduto.Text = id.ToString();
                Bloquear(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Bloquear(bool desabilitar)
        {
            BtnGerarId.Enabled = desabilitar;
        }

        private void HabilitarCampos(bool habilitar)
        {
            TxtFonrcedor.Enabled = habilitar;
            TxtPreco.Enabled = habilitar;
            TxtProduto.Enabled = habilitar;
            TxtRendimento.Enabled = habilitar;
            BtnSalvarDatas.Enabled = habilitar;
           BtnDeletar.Enabled = habilitar;
           BtnLimpar.Enabled = habilitar;          
        }
        private void DgvDatas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdData.Text = Convert.ToString(DgvDatas.Rows[e.RowIndex].Cells[0].Value);
            DtpAtualizado.Value = Convert.ToDateTime(DgvDatas.Rows[e.RowIndex].Cells[1].Value);
            TxtPreco.Text = Convert.ToString(DgvDatas.Rows[e.RowIndex].Cells[2].Value);
        }
        private void BtnSalvarDatas_Click(object sender, EventArgs e)
        {
            try
            {
                var dataproduto = lerdata();
                int ItensPropostaId = 0;
                if (TxtIdData.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtIdData.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtIdProduto.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtIdProduto.Text);
                }
                var listarmadeira = new DLdataproduto().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.produtoid == propostaid //por proppostaid
                                && ip.dataid == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.dataid > 0)
                {
                    prop.dataid = Convert.ToInt32(TxtIdData.Text);
                    prop.data = DtpAtualizado.Value;
                    prop.preco = TxtPreco.Text;
                    new DLdataproduto().Atualizar(prop);
                }
                else
                {
                    new DLdataproduto().Inserir(dataproduto);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }
                Carregargrid();
                TxtIdData.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            LiberarSalvar(true);
        }
        private void LiberarSalvar(bool habilitar)
        {
            BtnSalvarProduto.Enabled = habilitar;
        }
        private void BtnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Já Fez o Cadastro da Data primeiro ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool camposSaoValidos = Validarcampos();
                    if (camposSaoValidos == true)
                    {
                        int id = 0;
                        int.TryParse(TxtIdProduto.Text, out id);
                        if (id > 0)
                        {
                            var clientenovo = new DLprodutos().ConsultarPorId(id);
                            clientenovo.produto = TxtProduto.Text;
                            clientenovo.fornecedor = TxtFonrcedor.Text;
                            clientenovo.preco = TxtPreco.Text;
                            clientenovo.rendimento = TxtRendimento.Text;
                            clientenovo.comentario = RtbComentario.Text;
                            new DLprodutos().Atualizar(clientenovo);
                            MessageBox.Show("Material atualizado com Sucesso ");
                            Limparcampos();
                            Close();
                            DgvDatas.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtIdProduto.Text, out id);
                    if (id > 0)
                    {
                        new DLprodutos().Excluir(new produtos { produtoid = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        Carregargrid();
                        Limparcampos();
                        TxtIdProduto.Text = Convert.ToString(null);
                        Close();
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
        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            Limparcampos();
        }
        private void BtnDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir essa Data ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtIdData.Text, out id);
                    if (id > 0)
                    {
                        new DLdataproduto().Excluir(new dataproduto { dataid = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        Carregargrid();
                        Limparcampos();
                        TxtIdData.Text = Convert.ToString(null);
                       
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
    }
}
