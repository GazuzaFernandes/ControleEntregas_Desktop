using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
    public class Itensdata
    {
        public virtual int IdDatas { get; set; }
        public virtual string Fabrica { get; set; }
        public virtual DateTime Datas { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual int IdMadeiras { get; set; }
        public virtual int IdMaterial { get; set; }
    }
}
