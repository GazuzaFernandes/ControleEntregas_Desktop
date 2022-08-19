using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class Proposta
    {
        #region  Pasta - Sistema Logistica - Forme Proposta e Principal
        public virtual int propostaid { get; set; }
        public virtual DateTime dataprevista { get; set; }
        public virtual DateTime datapedido { get; set; }
        public virtual string fabrica { get; set; }
        public virtual string faturado { get; set; }
        public virtual string formapag { get; set; }
        public virtual string engresp { get; set; }
        public virtual string telefone { get; set; }
        public virtual string pdrb { get; set; }
        public virtual string pdvenda { get; set; }
        public virtual string material { get; set; }
        public virtual string propostaa { get; set; }
        public virtual string construtora { get; set; }
        public virtual string obra { get; set; }
        public virtual string comentario { get; set; }
        public virtual DateTime dataentrega { get; set; }
        public virtual string recebidopor { get; set; }
        public virtual string notafiscal { get; set; }
        public virtual string carreto { get; set; }
        public virtual int statusobraid { get; set; }
        #endregion
    }
}
