using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public class ControleGrid
    {

        DataGridView grid = null;
        private object DvgCarreto;

        public ControleGrid(DataGridView grid)
        {
            this.grid = grid;
        }

        public ControleGrid(object DvgCarreto)
        {
            this.DvgCarreto = DvgCarreto;
        }

        /// <summary>
        /// Define quais são as colunas visíveis
        /// </summary>
        /// <param name="ListaColunasVisiveis"></param>
        public void DefinirVisibilidade(List<string> ListaColunasVisiveis)
        {
            try
            {
                foreach (DataGridViewColumn coluna in grid.Columns)
                {
                    if (ListaColunasVisiveis.Contains(coluna.Name))
                        coluna.Visible = true;
                    else
                        coluna.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DefinirCampos(List<string> ListaColunas, List<string> ListaPropriedadesObjeto)
        {
            try
            {
                int i = 0;
                foreach (DataGridViewColumn coluna in grid.Columns)
                {
                    if (ListaColunas.Contains(coluna.Name))
                    {
                        coluna.DataPropertyName = ListaPropriedadesObjeto[i].ToString();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Altera o texto do cabeçalho da coluna
        /// </summary>
        /// <param name="ListaCabecalhos"></param>
        public void DefinirCabecalhos(List<string> ListaCabecalhos)
        {
            int index = 0;
            try
            {
                foreach (DataGridViewColumn coluna in grid.Columns)
                {
                    if (coluna.Visible)
                    {
                        if (index < ListaCabecalhos.Count)
                        {
                            coluna.HeaderText = ListaCabecalhos[index];
                            index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DefinirValoresCampos(List<string> ListaCampos, DataGridView grid)
        {
            foreach (DataGridViewColumn coluna in grid.Columns)
            {
                for (int i = 0; i < coluna.DataGridView.RowCount; i++)
                {
                }

            }
        }

        public void DefinirLarguras(List<int> ListaLarguras, Double larg)
        {
            int index = 0;
            try
            {
                //Defina largura da Grid
                foreach (DataGridViewColumn coluna in grid.Columns)
                {
                    if (coluna.Visible)
                    {

                        //int novaLargura = Porcertagem(ListaLarguras[index]);
                        Double lagu = Convert.ToDouble(larg);

                        //Double newLarg = ((larg - 600) * (ListaLarguras[index] / lagu)); //Antigo
                        Double newLarg = (Double)(larg * (Convert.ToDouble(ListaLarguras[index]) / 100));
                        //coluna.Width = Convert.ToInt32(newLarg * 18); //Antigo
                        coluna.Width = Convert.ToInt32(newLarg);
                        //coluna.Width = novaLargura;
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int Porcertagem(int PorcentagemColuna)
        {

            // calcula a largura percentual relacionada a grid
            return ((PorcentagemColuna * (grid.Width + 40)) / 100);
        }

        public void DefinirAlinhamento(List<string> ListaAlinhamento)
        {
            int index = 0;

            //Alienha o conteúdo da coluna da Grid
            foreach (DataGridViewColumn coluna in grid.Columns)
            {
                try
                {

                    if (ListaAlinhamento[index] == "esquerda") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    if (ListaAlinhamento[index] == "centro") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (ListaAlinhamento[index] == "direita") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    index++;

                    if (index == ListaAlinhamento.Count())
                        break;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        internal void DefinirLarguras(List<int> lists, object p)
        {
            throw new NotImplementedException();
        }

        public void DefinirAlturaLinha(int Altura)
        {
            try
            {
                foreach (DataGridViewRow linha in grid.Rows)
                {
                    linha.Height = Altura;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}