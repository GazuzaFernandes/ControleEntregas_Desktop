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
        public virtual int estoqueid { get; set; }
        public virtual string amostra { get; set; }
        public virtual decimal entrada { get; set; }
        public virtual decimal total { get; set; }
        #endregion
    }
}
