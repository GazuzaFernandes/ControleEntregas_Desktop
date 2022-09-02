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
        public virtual int StatusObraId { get; set; }
    }
}
