using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class ItensMaterial
    {
        #region  Pasta - Sistema Logistica - Form Estoque
        public virtual int materialid { get; set; }
        public virtual string material { get; set; }
        public virtual string unidademedida { get; set; }
        public virtual decimal total { get; set; }
        public virtual decimal entrada { get; set; }
        public virtual decimal quantidade { get; set; }
        #endregion
    }
}
