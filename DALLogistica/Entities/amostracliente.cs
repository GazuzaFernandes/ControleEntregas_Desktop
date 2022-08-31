using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
   public class AmostraCliente
    {
        #region Pasta - Sistema Amostra -  Form Amostra Cliente
        public virtual int AmostraId { get; set; }
        public virtual string Construtora { get; set; }
        public virtual DateTime DataEntrega { get; set; }
        public virtual string Obra { get; set; }
        public virtual string Material { get; set; }
        public virtual int StatusobraId { get; set; }

        #endregion
    }
}
