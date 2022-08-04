using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class itencontrole
    {
        #region Pasta - Sistema Logistica -  Form Saida Estoque
        public virtual int itencontroleid { get; set; }
        public virtual int codigo { get; set; }
        public virtual string material { get; set; }
        public virtual string undmedida { get; set; }
        public virtual decimal qtdcaixas { get; set; }
        public virtual decimal qtdsaida { get; set; }
        public virtual int controleid { get; set; }
        #endregion
    }
}
