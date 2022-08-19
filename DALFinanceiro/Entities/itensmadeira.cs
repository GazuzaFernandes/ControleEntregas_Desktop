using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
    public class Itensmadeira
    {
        public virtual int idmadeira { get; set; }
        public virtual int codigo { get; set; }
        public virtual string madeiras { get; set; }
        public virtual string medida { get; set; }
        public virtual decimal total { get; set; }
      
        public virtual int idprop { get; set; }
    }
}
