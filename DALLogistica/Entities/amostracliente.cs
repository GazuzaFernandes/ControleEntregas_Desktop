using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
   public class amostracliente
    {
        #region Pasta - Sistema Amostra -  Form Amostra Cliente
        public virtual int amostraid { get; set; }
        public virtual string construtora { get; set; }
        public virtual DateTime dataentrega { get; set; }
        public virtual string obra { get; set; }
        public virtual string material { get; set; }
        public virtual int statusobraid { get; set; }

        #endregion
    }
}
