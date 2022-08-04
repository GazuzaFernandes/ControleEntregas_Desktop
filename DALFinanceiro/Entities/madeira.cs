using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
  public  class madeira
    {
        public virtual int idmadeiras { get; set; }
        public virtual string fabrica { get; set; }
        public virtual string madeiras { get; set; }
        public virtual string unidademedida { get; set; }
        public virtual decimal entrada { get; set; }
        public virtual DateTime datas { get; set; }
        public virtual decimal total { get; set; }       
        public virtual string comentario { get; set; }
        public virtual int rbcomercio { get; set; }
        public virtual int rbengenharia { get; set; }
        public virtual int rbpisos { get; set; }
        public virtual int codigo { get; set; }
        public virtual string madeirasaida { get; set; }
        public virtual string unidademedidaSaida { get; set; }
        public virtual decimal saida { get; set; }
        public virtual decimal totalsaida { get; set; }    
        public virtual int statusobraid { get; set; }
      
    }
}
