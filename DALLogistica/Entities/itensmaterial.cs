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
        public virtual int MaterialId { get; set; }
        public virtual string Material { get; set; }
        public virtual string UnidadeMedida { get; set; }
        public virtual decimal Total { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual decimal Quantidade { get; set; }
        #endregion
    }
}
