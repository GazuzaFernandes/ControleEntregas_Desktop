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
        public virtual int RegrasId { get; set; }
        public virtual string Material { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Tributos { get; set; }
        public virtual string Ncm { get; set; }
        public virtual string CstSaida { get; set; }
        public virtual string CfopSaidaSp { get; set; }
        public virtual string CfopSaidaoutrosufPj { get; set; }
        public virtual string CfopSaidaoutrosufPf { get; set; }

        #endregion
    }
}
