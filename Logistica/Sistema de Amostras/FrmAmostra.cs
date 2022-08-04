using DALLogistica.Entities;
using DALLogistica.Repository;
using LogisticaEntregas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica.Sistema_de_Amostras
{
    public partial class FrmAmostra : Form
    {
        internal amostra _amostracliente;
        public FrmAmostra()
        {
            InitializeComponent();
        }
        private void FrmAmostra_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                tabPage1.BackColor = Color.FromArgb(0, 64, 0);
                tabPage2.BackColor = Color.FromArgb(0, 64, 0);
                if (_amostracliente == null)
                    _amostracliente = new amostra();
                if (_amostracliente.amostraid > 0)
                {
                    HabilitarCampos(true);
                    _amostracliente = new DLamostra().ConsultarPorId(_amostracliente.amostraid);
                    TxtAmostraId.Text = _amostracliente.amostraid.ToString();
                    DtpDataentrega.Value = _amostracliente.dataentrega;
                    RtbComentario.Text = _amostracliente.material;
                    TxtConstrutora.Text = _amostracliente.construtora;
                    TxtObra.Text = _amostracliente.obra;
                    switch (_amostracliente.statusobraid)//escolha
                    {
                        case 2:
                            {
                                RbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                RbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                RbCancelado.Checked = true;
                            }
                            break;
                    }
                    bloquearbotao(false);
                    CarregarGrid();               
                }
                else
                {
                    RbPendente.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                var lstitensproposta = new DLitensamostra().Listar().Where(p => p.amostraid == Convert.ToInt32(TxtAmostraId.Text)).ToList();
                DgvAmostra.DataSource = null;
                DgvAmostra.DataSource = lstitensproposta;
                DgvAmostra.Refresh(); MontarGrid(DgvAmostra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGrid(DataGridView dgvAmostra)
        {
            try
            {
                DgvAmostra.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvAmostra);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "codigo", "material", "quantidade", "observacao", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Codigo", "Material", "Quantidade", "Observãção", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 10, 64, 10, 10 }, DgvAmostra.Width - 15); //O total tem que ficar em 100% 
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
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLamostra().ConsultarPorId(id);
                        atualizar.dataentrega = DtpDataentrega.Value;
                        atualizar.construtora = TxtConstrutora.Text;
                        atualizar.obra = TxtObra.Text;                       
                        if (RbPendente.Checked == true)
                            atualizar.statusobraid = 2;
                        else if (RbFinalizado.Checked == true)
                            atualizar.statusobraid = 3;
                        else if (RbCancelado.Checked == true)
                            atualizar.statusobraid = 4;
                        new DLamostra().Atualizar(atualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                        LimparAmostra();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private bool Validarcampos()
        {
            if (TxtConstrutora.Text == "")
            {
                throw new Exception("Informe o Cliente");
            }
           
            return true;
        }
        private void LimparAmostra()
        {
            DtpDataentrega.Value = DateTime.Now;
            TxtConstrutora.Text = Convert.ToString(null);
            TxtObra.Text = Convert.ToString(null);
            
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa Amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(TxtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        new DLamostra().Excluir(new amostra { amostraid = id });
                        MessageBox.Show("Amostra excluída com sucesso!");
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
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoqueAmostra estoque = new FrmEstoqueAmostra();
                estoque.ShowDialog();

                var itensamostraid = estoque.itensamostraid;               
                var material = estoque.material;
                var quantidade = estoque.quantidade;
              
                TxtCodigoMadeira.Text = itensamostraid.ToString();
                TxtMaterial.Text = material;
                TxtSaidaMadeira.Text = quantidade.ToString();
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
                var itensamostra = lercampos();
                int ItensPropostaId = 0;
                if (TxtTabelaId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(TxtTabelaId.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (TxtAmostraId.Text != "")
                {
                    propostaid = Convert.ToInt32(TxtAmostraId.Text);
                }
                var listaProposta = new DLitensamostra().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.amostraid == propostaid //por proppostaid
                                && ip.itensamostraid == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.itensamostraid > 0)
                {
                    prop.codigo = Convert.ToInt32(TxtCodigoMadeira.Text);
                    prop.material = TxtMaterial.Text;
                    prop.observacao = TxtObs.Text;
                    prop.quantidade = Convert.ToDecimal(TxtSaidaMadeira.Text);                     
                    new DLitensamostra().Atualizar(prop);
                }
                else
                {
                    new DLitensamostra().Inserir(itensamostra);
               
                }
                LimparCamposItens();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }        
        private itensamostra lercampos()
        {
            try
            {
                var iten = new itensamostra();
                int id = 0;
                int.TryParse(TxtTabelaId.Text, out id);
                if (id == 0)
                {
                    iten.codigo = Convert.ToInt32(TxtCodigoMadeira.Text);
                    iten.material = TxtMaterial.Text;
                    iten.observacao = TxtObs.Text;
                    iten.quantidade = Convert.ToDecimal(TxtSaidaMadeira.Text);
                    iten.amostraid = Convert.ToInt32(TxtAmostraId.Text);
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
                int.TryParse(TxtTabelaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLitensamostra().ConsultarPorId(id);
                    if (prop.itensamostraid > 0)
                    {
                        new DLitensamostra().Excluir(prop);
                        CarregarGrid(); LimparCamposItens();
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
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCamposItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCamposItens()
        {
            TxtTabelaId.Text = Convert.ToString(null);
            TxtCodigoMadeira.Text = Convert.ToString(null);
            TxtMaterial.Text = Convert.ToString(null);
            TxtSaidaMadeira.Text = Convert.ToString(null);
            TxtObs.Text = Convert.ToString(null);
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueAmostra estoque = new FrmEstoqueAmostra();
            estoque.ShowDialog();
        }
        private void BtnGerarAmostra_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var amostra = new amostra();
                amostra.statusobraid = 2;//Pendente
                var id = new DLamostra().Inserir(amostra);//inserir
                TxtAmostraId.Text = id.ToString();
                bloquearbotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void bloquearbotao(bool bloquear)
        {
            BtnGerarAmostra.Enabled = bloquear;
        }
        private void HabilitarCampos(bool habilitar)
        {
            TxtConstrutora.Enabled = habilitar;
            TxtObra.Enabled = habilitar;
            BtnSalvar.Enabled = habilitar;
            BtnDeletar.Enabled = habilitar;
            TxtObs.Enabled = habilitar;
            BtnPesquisar.Enabled = habilitar;
            BtnInserir.Enabled = habilitar;
            BtnApagar.Enabled = habilitar;
            BtnLimpar.Enabled = habilitar;
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtTabelaId.Text = Convert.ToString(DgvAmostra.Rows[e.RowIndex].Cells[0].Value);
                TxtCodigoMadeira.Text = Convert.ToString(DgvAmostra.Rows[e.RowIndex].Cells[1].Value);
                TxtMaterial.Text = Convert.ToString(DgvAmostra.Rows[e.RowIndex].Cells[2].Value);
                TxtSaidaMadeira.Text = Convert.ToString(DgvAmostra.Rows[e.RowIndex].Cells[3].Value);
                TxtObs.Text = Convert.ToString(DgvAmostra.Rows[e.RowIndex].Cells[4].Value);
                HabilitarCampos(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
