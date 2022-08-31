using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
    public class Itensmadeira
    {
        public virtual int IdMadeira { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Madeiras { get; set; }
        public virtual string Medida { get; set; }
        public virtual decimal Total { get; set; }      
        public virtual int IdProp { get; set; }
    }
}
