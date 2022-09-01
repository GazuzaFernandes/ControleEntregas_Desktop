using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
    public class Madeira
    {
        public virtual int IdMadeiras { get; set; }
        public virtual string Madeiras { get; set; }
        public virtual string UnidadeMedida { get; set; }
        public virtual decimal Total { get; set; }
        public virtual string Fabrica { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual DateTime Datas { get; set; }
        public virtual string Comentario { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Madeirasaida { get; set; }
        public virtual string UnidadeMedidaSaida { get; set; }
        public virtual decimal Saida { get; set; }
        public virtual decimal TotalSaida { get; set; }
        public virtual int StatusObraId { get; set; }
    }
}
