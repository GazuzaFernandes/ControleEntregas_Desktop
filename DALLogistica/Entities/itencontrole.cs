using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class ItenControle
    {
        #region Pasta - Sistema Logistica -  Form Saida Estoque
        public virtual int ItencontroleId { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Material { get; set; }
        public virtual string UndMedida { get; set; }
        public virtual decimal QtdCaixas { get; set; }
        public virtual decimal QtdSaida { get; set; }
        public virtual int ControleId { get; set; }
        #endregion
    }
}
