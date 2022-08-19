
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
        private void CarregarFerramenta(bool isPesquisa = false)
        {
            try
            {
                var listarFerramentas = new DLFerramentas().Listarferramenta();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked)
                        listarFerramentas = listarFerramentas.Where(p => p.funcionario.ToLower().Contains(pesquisa)).ToList();
                }
                DgvFerramentas.DataSource = listarFerramentas;
                MontarFerramentas(DgvFerramentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarFerramentas(DataGridView dgvFerramentas)
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
        private void CarregarPrincipal(bool isPesquisa = false)
        {
            try
            {
                var listaPropostaStatus = new DLProposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    #region Pesquisa
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbFabrica.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.fabrica.ToLower().Contains(pesquisa)).ToList();
                    else if (RbMaterial.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(x => x.material.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEng.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.engresp.ToLower().Contains(pesquisa)).ToList();
                    else if (RbPedidoRb.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdrb.ToLower().Contains(pesquisa)).ToList();
                    else if (RbPedidoVenda.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdvenda.ToLower().Contains(pesquisa)).ToList();
                    else if (RbProposta.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.propostaa.ToLower().Contains(pesquisa)).ToList();
                    else if (RbCliente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEndereco.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (RbComentario.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.comentario.ToLower().Contains(pesquisa)).ToList();
                    else if (RbNf.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.notafiscal.ToLower().Contains(pesquisa)).ToList();
                    #endregion
                    #region Status
                    if (CkFinalizar.Checked)//==
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Finalizado")).ToList();
                    else if (CkPendente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Pendente")).ToList();
                    else if (CkImediato.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Imediato")).ToList();
                    else if (CkCancelado.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Cancelado")).ToList();
                    #endregion
                }
                DgvPrincipal.DataSource = listaPropostaStatus;
                MontarProposta(DgvPrincipal);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarProposta(DataGridView dgvPrincipal)
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
        private void BtnProposta_Click(object sender, EventArgs e)
        {
            FrmPropostas proposta = new FrmPropostas();
            proposta.ShowDialog();
            CarregarPrincipal();
        }
        private void BtnFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas ferramenta = new FrmFerramentas();
            ferramenta.ShowDialog();
            CarregarFerramenta();
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
        private void ReducaoCodigoPesquisar()
        {
            CarregarFerramenta(true);
            MontarFerramentas(DgvFerramentas);
            CarregarPrincipal(true);
            MontarProposta(DgvPrincipal);
        }
        private void ReducaoCodigoLimpeza()
        {
            try
            {
                TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
                RbFabrica.Checked = false;
                RbEng.Checked = false;
                RbPedidoRb.Checked = false;
                RbEndereco.Checked = false;
                RbPedidoVenda.Checked = false;
                RbNf.Checked = false;
                RbMaterial.Checked = false;
                RbProposta.Checked = false;
                RbComentario.Checked = false;
                CkCancelado.Checked = false;
                RbCliente.Checked = false;
                CkFinalizar.Checked = false;
                CkPendente.Checked = false;
                CkImediato.Checked = false;
                CarregarFerramenta();
                CarregarPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString(null);
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
        private void calcularverniz()
        {
            try
            {
                decimal verniz = 0;
                decimal m2verniz = 0;
                decimal basev = 0;
                decimal m2base = 0;
                decimal totalverniz = 0;
                decimal totalbase = 0;
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
        private void calcularcetol()
        {
            try
            {
                decimal cetol = 0;
                decimal m2cetol = 0;
                decimal totalcetol = 0;
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
        private void calcularwakol()
        {
            try
            {
                decimal terreo = 0;
                decimal m2terro = 0;
                decimal superior = 0;
                decimal m2superior = 0;
                decimal totalterreo = 0;
                decimal totalsuperior = 0;
                if (decimal.TryParse(Txtm2Terreo.Text, out terreo))
                {
                    if (decimal.TryParse(TxtTerroWakol.Text, out m2terro))
                    {
                        totalterreo = terreo / m2terro;
                    }
                    if (decimal.TryParse(Txtm2Superior.Text, out m2superior))
                    {
                        if (decimal.TryParse(TxtSuperiorWakol.Text, out superior))
                        {
                            totalsuperior = m2superior / superior;
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
                    TxtTotalSuperior.Text = totalsuperior.ToString("N2");
                    TxtTotalTerreo.Text = totalterreo.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void calcuparpresilha()
        {
            try
            {
                #region Calculo do Deck Presilhas
                decimal LarDeck = 0;
                decimal Largura = 0;
                decimal totaldeck = 0;
                if (decimal.TryParse(TxtLargura.Text, out Largura))
                {
                    if (decimal.TryParse(TxtLarguraDeck.Text, out LarDeck))
                    {
                        totaldeck = Largura / LarDeck;
                    }
                    TxtTotalDeck.Text = totaldeck.ToString("N2");
                    #endregion

                    #region Calculo Linha 2
                    decimal Linha1 = 0;
                    decimal Linha2 = 0;
                    decimal Coluna3 = 0;
                    decimal totallinha2 = 0;
                    if (decimal.TryParse(TxtComprimento.Text, out Linha1))
                    {
                        if (decimal.TryParse(TxtLargDeck.Text, out Linha2))
                        {
                            if (decimal.TryParse(Txtm2Area.Text, out Coluna3))

                                totallinha2 = Linha1 * Linha2 / Coluna3;
                        }
                        TxtPresilha.Text = totallinha2.ToString("N2");
                        #endregion

                        #region Linha 3 Final
                        decimal PresilhaM2 = 0;
                        decimal M2Pedido = 0;
                        decimal totalpresilha = 0;
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
                            #endregion

                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void valormdf()
        {
            try
            {
                decimal largura = 0;
                decimal rodape = 0;
                decimal comprimento = 0;
                decimal total = 0;

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
            }
        }
        private void calcularm2()
        {
            try
            {
                decimal comprimento = 0;
                decimal largura = 0;
                decimal total = 0;
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
        private void calcularm3()
        {
            try
            {
                decimal comprimento = 0;
                decimal espessura = 0;
                decimal total = 0;
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
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProposta = new DLProposta().Listar();
                CarregarPrincipal();
                var listarferramenta = new DLFerramentas().Listar();
                CarregarFerramenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmSaidaEstoque estoque = new FrmSaidaEstoque();
            estoque.Show();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
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
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoLimpeza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvPrincipal_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new Proposta();
                prop.propostaid = Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                FrmPropostas frmproposta = new FrmPropostas();
                frmproposta._proposta = prop;
                frmproposta.ShowDialog();
                CarregarPrincipal();
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
                ferra.ferramentaid = Convert.ToInt32(DgvFerramentas.Rows[e.RowIndex].Cells[0].Value);
                FrmFerramentas frmFerramentas = new FrmFerramentas();
                frmFerramentas._ferramentas = ferra;
                frmFerramentas.ShowDialog();
                CarregarFerramenta();
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
        private void TxtLarguraMDF_TextChanged_1(object sender, EventArgs e)
        {
            valormdf();
        }
        private void TxtRodape_TextChanged_1(object sender, EventArgs e)
        {
            valormdf();
        }
        private void TxtComprimentoMDF_TextChanged_1(object sender, EventArgs e)
        {
            valormdf();
        }
        private void Txtm2Comprimento_TextChanged_1(object sender, EventArgs e)
        {
            calcularm2();
        }
        private void Txtm2Largura_TextChanged_1(object sender, EventArgs e)
        {
            calcularm2();
        }
        private void Txtm2_TextChanged(object sender, EventArgs e)
        {
            calcularm3();
        }
        private void TxtM3Espessura_TextChanged_1(object sender, EventArgs e)
        {
            calcularm3();
        }
        private void Txtm2Verniz_TextChanged_1(object sender, EventArgs e)
        {
            calcularverniz();
        }
        private void TxtVerniz_TextChanged_1(object sender, EventArgs e)
        {
            calcularverniz();
        }
        private void Txtm2Base_TextChanged_1(object sender, EventArgs e)
        {
            calcularverniz();
        }
        private void TxtBase_TextChanged_1(object sender, EventArgs e)
        {
            calcularverniz();
        }
        private void Txtm2Cetol_TextChanged_1(object sender, EventArgs e)
        {
            calcularcetol();
        }
        private void TxtCetol_TextChanged_1(object sender, EventArgs e)
        {
            calcularcetol();
        }
        private void Txtm2Terreo_TextChanged_1(object sender, EventArgs e)
        {
            calcularwakol();
        }
        private void TxtTerroWakol_TextChanged_1(object sender, EventArgs e)
        {
            calcularwakol();
        }
        private void Txtm2Superior_TextChanged_1(object sender, EventArgs e)
        {
            calcularwakol();
        }
        private void TxtSuperiorWakol_TextChanged_1(object sender, EventArgs e)
        {
            calcularwakol();
        }
        private void TxtLargura_TextChanged(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void TxtLarguraDeck_TextChanged_1(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void TxtComprimento_TextChanged_1(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void TxtLargDeck_TextChanged(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void Txtm2Area_TextChanged_1(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void TxtPresilham2_TextChanged_1(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
        private void Txtm2Pedido_TextChanged(object sender, EventArgs e)
        {
            calcuparpresilha();
        }
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
                                           $@"C:\Users\logistica\source\repos\BACKUP\SistemaLogistica\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                             @"SistemaLogistica");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnRestaurarSistema_Click(object sender, EventArgs e)
        {

        }
    }
}
