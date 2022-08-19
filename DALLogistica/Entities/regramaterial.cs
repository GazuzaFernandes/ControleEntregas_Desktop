using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class RegraMaterial
    {
        #region Pasta - Sistema Logistica - Form de Nota Fiscal
        public virtual int regrasid { get; set; }
        public virtual string material { get; set; }
        public virtual string codigo { get; set; }
        public virtual string tributos { get; set; }
        public virtual string ncm { get; set; }
        public virtual string cstsaida { get; set; }
        public virtual string cfopsaidasp { get; set; }
        public virtual string cfopsaidaoutrosufpj { get; set; }
        public virtual string cfopsaidaoutrosufpf { get; set; }

        #endregion
    }
}
