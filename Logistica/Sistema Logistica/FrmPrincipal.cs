
using DALLogistica.Entities;
using DALLogistica.Repository;
using DALSenhas.Repository;
using Logistica.Sistema_Logistica;
using NHibernate;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Logistica.BackupAutomatico;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace LogisticaEntregas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProposta = new DLProposta().Listar();
                CarregarGridPrincipal();
                var listarferramenta = new DLFerramentas().Listar();
                CarregarGridFerramenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        #region Campo de Metodos
        private void CarregarGridFerramenta(bool isPesquisa = false)
        {
            try
            {
                var listarFerramentas = new DLFerramentas().Listarferramenta();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)
                        listarFerramentas = listarFerramentas.Where(p => p.funcionario.ToLower().Contains(pesquisa)).ToList();
                }
                DgvFerramentas.DataSource = listarFerramentas;
                MontarGridFerramentas(DgvFerramentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridFerramentas(DataGridView dgvFerramentas)
        {
            #region Montar Grid Ferramentas
            DgvFerramentas.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvFerramentas);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "funcionario", "retirada", "devolucao", "material", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "FUNCIONARIO", "RETIRADA", "DEVOLUÇÃO", "MATERIAL", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 10, 50, }, DgvFerramentas.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
            #endregion
        }
        private void CarregarGridPrincipal(bool isPesquisa = false)
        {
            try
            {
                var listaPropostaStatus = new DLProposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    #region Pesquisa
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbFabrica.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.fabrica.ToLower().Contains(pesquisa)).ToList();
                    else if (RbMaterial.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(x => x.material.ToLower().Contains(pesquisa)).ToList();
                    else if (rbEng.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.engresp.ToLower().Contains(pesquisa)).ToList();
                    else if (rbPedidoRb.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdrb.ToLower().Contains(pesquisa)).ToList();
                    else if (rbPedidoVenda.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdvenda.ToLower().Contains(pesquisa)).ToList();
                    else if (rbProposta.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.propostaa.ToLower().Contains(pesquisa)).ToList();
                    else if (rbCliente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEndereco.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbComentario.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.comentario.ToLower().Contains(pesquisa)).ToList();
                    else if (rbNotaFiscal.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.notafiscal.ToLower().Contains(pesquisa)).ToList();
                    #endregion
                    #region Status
                    if (ckFinalizar.Checked)//==
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Finalizado")).ToList();
                    else if (ckPendente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Pendente")).ToList();
                    else if (ckImediato.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Imediato")).ToList();
                    else if (ckCancelado.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Cancelado")).ToList();
                    #endregion
                }
                DgvPrincipal.DataSource = listaPropostaStatus;
                MontarGridProposta(DgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridProposta(DataGridView dgvPrincipal)
        {
            DgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "dataprevista", "fabrica", "engresp", "pdrb", "pdvenda", "propostaa", "construtora", "obra", "notafiscal", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "DATA PREVISTA", "FABRICA", "RESP.", "PD RB", "PD VENDA", "PROPOSTA", "CLIENTE", "OBRA", "NF", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 9, 9, 7, 8, 8, 8, 12, 27, 7, }, DgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void ReducaoCodigoPesquisar()
        {
            CarregarGridFerramenta(true);
            MontarGridFerramentas(DgvFerramentas);
            CarregarGridPrincipal(true);
            MontarGridProposta(DgvPrincipal);
        }
        private void ReducaoCodigoLimpeza()
        {
            try
            {
                txtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
                rbFabrica.Checked = false;
                rbEng.Checked = false;
                rbPedidoRb.Checked = false;
                RbEndereco.Checked = false;
                rbPedidoVenda.Checked = false;
                rbNotaFiscal.Checked = false;
                RbMaterial.Checked = false;
                rbProposta.Checked = false;
                rbComentario.Checked = false;
                ckCancelado.Checked = false;
                rbCliente.Checked = false;
                ckFinalizar.Checked = false;
                ckPendente.Checked = false;
                ckImediato.Checked = false;
                CarregarGridFerramenta();
                CarregarGridPrincipal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularVerniz()
        {
            try
            {
                decimal verniz = 0, m2verniz = 0, basev = 0, m2base = 0, totalverniz = 0, totalbase = 0;
                if (decimal.TryParse(TxtVerniz.Text, out verniz))
                {
                    if (decimal.TryParse(Txtm2Verniz.Text, out m2verniz))
                    {
                        totalverniz = m2verniz / verniz;
                    }

                    if (decimal.TryParse(TxtBase.Text, out basev))
                    {
                        if (decimal.TryParse(Txtm2Base.Text, out m2base))
                        {
                            totalbase = m2base / basev;
                        }
                        else
                        {
                            MessageBox.Show("Quantidade inválida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor Invalido");
                    }
                    TxtTotalVerniz.Text = totalverniz.ToString("N2");
                    TxtTotalBase.Text = totalbase.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularCetol()
        {
            try
            {
                decimal cetol = 0, m2cetol = 0, totalcetol = 0;
                if (decimal.TryParse(TxtCetol.Text, out cetol))
                {
                    if (decimal.TryParse(Txtm2Cetol.Text, out m2cetol))
                    {
                        totalcetol = m2cetol / cetol;
                    }
                    else
                    {
                        MessageBox.Show("Valor Invalido");
                    }
                    TxtTotalCetol.Text = totalcetol.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularWakol()
        {
            try
            {
                decimal terreo = 0, m2terro = 0, superior = 0, m2superior = 0, totalterreo = 0, totalsuperior = 0;

                if (decimal.TryParse(Txtm2Terreo.Text, out terreo))
                {
                    if (decimal.TryParse(TxtTerroWakol.Text, out m2terro))
                    {
                        totalterreo = terreo / m2terro;
                    }
                }

                else if (decimal.TryParse(Txtm2Superior.Text, out m2superior))
                {
                    if (decimal.TryParse(TxtSuperiorWakol.Text, out superior))
                    {
                        totalsuperior = m2superior / superior;
                    }
                }

                else
                {
                    MessageBox.Show("Valor Invalido");
                }

                TxtTotalSuperior.Text = totalsuperior.ToString("N2");
                TxtTotalTerreo.Text = totalterreo.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularPresilhas()
        {
            try
            {
                #region Calculo do Deck Presilhas
                decimal LarDeck = 0, Largura = 0, totaldeck = 0;
                if (decimal.TryParse(TxtLargura.Text, out Largura))
                {
                    if (decimal.TryParse(TxtLarguraDeck.Text, out LarDeck))
                    {
                        totaldeck = Largura / LarDeck;
                    }
                    TxtTotalDeck.Text = totaldeck.ToString("N2");
                }
                #endregion

                #region Calculo Linha 2
                decimal Linha1 = 0, Linha2 = 0, Coluna3 = 0, totallinha2 = 0;
                if (decimal.TryParse(TxtComprimento.Text, out Linha1))
                {
                    if (decimal.TryParse(TxtLargDeck.Text, out Linha2))
                    {
                        if (decimal.TryParse(Txtm2Area.Text, out Coluna3))

                            totallinha2 = Linha1 * Linha2 / Coluna3;
                    }
                    TxtPresilha.Text = totallinha2.ToString("N2");
                }
                #endregion

                #region Linha 3 Final
                decimal PresilhaM2 = 0, M2Pedido = 0, totalpresilha = 0;
                if (decimal.TryParse(TxtPresilham2.Text, out PresilhaM2))
                {
                    if (decimal.TryParse(Txtm2Pedido.Text, out M2Pedido))
                    {
                        totalpresilha = PresilhaM2 * M2Pedido;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                    TxtTotalPresilha.Text = totalpresilha.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ValorMdf()
        {
            try
            {
                decimal largura = 0, rodape = 0, comprimento = 0, total = 0;
                if (decimal.TryParse(TxtLarguraMDF.Text, out largura))
                {
                    if (decimal.TryParse(TxtRodape.Text, out rodape))
                    {
                        if (decimal.TryParse(TxtComprimentoMDF.Text, out comprimento))

                            total = largura / rodape * comprimento;
                    }
                }
                else
                {
                    MessageBox.Show("Valor Invalido");
                }
                TxtTotalMDF.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularM2()
        {
            try
            {
                decimal comprimento = 0, largura = 0, total = 0;
                if (decimal.TryParse(Txtm2Comprimento.Text, out comprimento))
                {
                    if (decimal.TryParse(Txtm2Largura.Text, out largura))
                    {
                        total = largura * comprimento;
                    }
                }
                else
                {
                    MessageBox.Show("Valor Invalido");
                }
                Txtm2Total.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularM3()
        {
            try
            {
                decimal comprimento = 0, espessura = 0, total = 0;
                if (decimal.TryParse(Txtm2.Text, out comprimento))
                {
                    if (decimal.TryParse(TxtM3Espessura.Text, out espessura))
                    {
                        total = comprimento * espessura;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                }
                TxtTotalm3.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Botões Principais
        private void BtnProposta_Click(object sender, EventArgs e)
        {
            FrmPropostas proposta = new FrmPropostas();
            proposta.ShowDialog();
            CarregarGridPrincipal();
        }
        private void BtnFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas ferramenta = new FrmFerramentas();
            ferramenta.ShowDialog();
            CarregarGridFerramenta();
        }
        private void BtnMaterial_Click(object sender, EventArgs e)
        {
            FrmMaterial material = new FrmMaterial();
            material.ShowDialog();
        }
        private void BtnNotaFiscal_Click(object sender, EventArgs e)
        {
            FrmNotaFical notafiscal = new FrmNotaFical();
            notafiscal.ShowDialog();
        }
        private void BtnArt_Click(object sender, EventArgs e)
        {
            FrmArt art = new FrmArt();
            art.ShowDialog();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmSaidaEstoque estoque = new FrmSaidaEstoque();
            estoque.Show();
        }

        #endregion

        #region Apenas Grid
        private void DgvPrincipal_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new Proposta();
                prop.PropostaId = Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                FrmPropostas frmproposta = new FrmPropostas();
                frmproposta._proposta = prop;
                frmproposta.ShowDialog();
                CarregarGridPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvPrincipal_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvPrincipal.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvPrincipal.Rows[i].Cells[21].Value);
                switch (valor)
                {
                    case "Imediato": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Pendente": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case "Finalizado": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvFerramentas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ferra = new Ferramentas();
                ferra.FerramentaId = Convert.ToInt32(DgvFerramentas.Rows[e.RowIndex].Cells[0].Value);
                FrmFerramentas ferramenta = new FrmFerramentas();
                ferramenta._ferramentas = ferra;
                ferramenta.ShowDialog();
                CarregarGridFerramenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvFerramentas_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvFerramentas.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvFerramentas.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                }
            }
        }

        #endregion

        #region Separação dos Text Box
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString(null);
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoPesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void TxtLarguraMDF_TextChanged_1(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void TxtRodape_TextChanged_1(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void TxtComprimentoMDF_TextChanged_1(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void Txtm2Comprimento_TextChanged_1(object sender, EventArgs e)
        {
            CalcularM2();
        }
        private void Txtm2Largura_TextChanged_1(object sender, EventArgs e)
        {
            CalcularM2();
        }
        private void Txtm2_TextChanged(object sender, EventArgs e)
        {
            CalcularM3();
        }
        private void TxtM3Espessura_TextChanged_1(object sender, EventArgs e)
        {
            CalcularM3();
        }
        private void Txtm2Verniz_TextChanged_1(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void TxtVerniz_TextChanged_1(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void Txtm2Base_TextChanged_1(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void TxtBase_TextChanged_1(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void Txtm2Cetol_TextChanged_1(object sender, EventArgs e)
        {
            CalcularCetol();
        }
        private void TxtCetol_TextChanged_1(object sender, EventArgs e)
        {
            CalcularCetol();
        }
        private void Txtm2Terreo_TextChanged_1(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void TxtTerroWakol_TextChanged_1(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void Txtm2Superior_TextChanged_1(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void TxtSuperiorWakol_TextChanged_1(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void TxtLargura_TextChanged(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void TxtLarguraDeck_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void TxtComprimento_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void TxtLargDeck_TextChanged(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void Txtm2Area_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void TxtPresilham2_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        private void Txtm2Pedido_TextChanged(object sender, EventArgs e)
        {
            CalcularPresilhas();
        }
        #endregion

        #region Botões Secundarios
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ReducaoCodigoPesquisar();
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            ReducaoCodigoLimpeza();
        }
        private void BtnDeletarRodape_Click(object sender, EventArgs e)
        {
            TxtLarguraMDF.Text = Convert.ToString("1,84");
            TxtComprimentoMDF.Text = Convert.ToString("2,75");
            TxtRodape.Text = Convert.ToString("0,1");
            TxtTotalMDF.Text = Convert.ToString(0);
        }
        private void BtnDeletarm2_Click(object sender, EventArgs e)
        {
            Txtm2Comprimento.Text = Convert.ToString(0);
            Txtm2Largura.Text = Convert.ToString(0);
            Txtm2Total.Text = Convert.ToString(0);
        }
        private void BtnDeletarM3_Click(object sender, EventArgs e)
        {
            Txtm2.Text = Convert.ToString(0);
            TxtM3Espessura.Text = Convert.ToString(0);
            TxtTotalm3.Text = Convert.ToString(0);
        }
        private void BtnLimparVerniz_Click(object sender, EventArgs e)
        {
            Txtm2Verniz.Text = Convert.ToString(0);
            TxtTotalVerniz.Text = Convert.ToString(0);
            Txtm2Base.Text = Convert.ToString(0);
            TxtTotalBase.Text = Convert.ToString(0);
        }
        private void BtnLimparcetol_Click(object sender, EventArgs e)
        {
            Txtm2Cetol.Text = Convert.ToString(0);
            TxtTotalCetol.Text = Convert.ToString(0);
        }
        private void BtnLimprWakol_Click(object sender, EventArgs e)
        {
            Txtm2Terreo.Text = Convert.ToString(0);
            TxtTotalTerreo.Text = Convert.ToString(0);
            Txtm2Superior.Text = Convert.ToString(0);
            TxtTotalSuperior.Text = Convert.ToString(0);
        }
        private void BtnLimparPresilhas_Click(object sender, EventArgs e)
        {
            TxtLarguraDeck.Text = Convert.ToString(0);
            TxtTotalDeck.Text = Convert.ToString(0);
            TxtLargDeck.Text = Convert.ToString(0);
            TxtPresilha.Text = Convert.ToString(0);
            TxtPresilham2.Text = Convert.ToString(0);
            Txtm2Pedido.Text = Convert.ToString(0);
            TxtTotalPresilha.Text = Convert.ToString(0);
        }
        #endregion

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FunctionsDataBase.BackupDatabase(
                                             "192.168.0.202",
                                             "5432",
                                             "postgres",
                                             "q1s2e3f4t5",
                                             "RBCOMERCIO",
                                           $@"F:\_LOGISTICA\Restauração\SistemaLogistica\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaLogistica");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
