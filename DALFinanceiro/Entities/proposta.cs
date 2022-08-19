using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
   public class Proposta
    {
        public virtual int idprop { get; set; }
        public virtual DateTime emissaonf { get; set; }
        public virtual DateTime vencimentonf { get; set; }
        public virtual string cliente { get; set; }
        public virtual string email { get; set; }
        public virtual string propostas { get; set; }
        public virtual string notafiscal { get; set; }
        public virtual string obra { get; set; }
        public virtual string cometario { get; set; }
        public virtual int statusobraid { get; set; }
        public virtual int rbcomercio { get; set; }
        public virtual int rbengenharia { get; set; }
        public virtual int rbpisos { get; set; }


    }
}
