using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class EstoqueAmostra
    {
        #region Pasta Sistema de Amostra - Form Estoque de Amostra
        public virtual int EstoqueId { get; set; }
        public virtual string Amostra { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual decimal Total { get; set; }
        #endregion
    }
}
