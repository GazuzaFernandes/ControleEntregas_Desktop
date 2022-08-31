using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
   public class Proposta
    {
        public virtual int IdProp { get; set; }
        public virtual DateTime EmissaoNf { get; set; }
        public virtual DateTime VencimentoNf { get; set; }
        public virtual string Cliente { get; set; }    
        public virtual string Propostas { get; set; }
        public virtual string Notafiscal { get; set; }
        public virtual string Obra { get; set; }
        public virtual string Email { get; set; }
        public virtual string Cometario { get; set; }
        public virtual int StatusobraId { get; set; }
    }
}
