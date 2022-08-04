using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class historico
    {
        #region Pasta - Sistema Logistica -  Form Logistica
        public virtual int historicoid { get; set; }
        public virtual DateTime datacomentario { get; set; }
        public virtual string comentario { get; set; }
      
        public virtual int propostaid { get; set; }
        #endregion
    }
}
