using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
    public class Itensdata
    {
        public virtual int iddatas { get; set; }
        public virtual string fabrica { get; set; }
        public virtual DateTime datas { get; set; }
        public virtual decimal entrada { get; set; }
        public virtual int idmadeiras { get; set; }
        
        public virtual int idmaterial { get; set; }
    }
}
