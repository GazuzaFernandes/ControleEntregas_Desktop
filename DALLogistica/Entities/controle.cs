using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class Controle
    {
        #region Pasta - Sistema Logistica - Form Saida Estoque
        public virtual int controleid { get; set; }
        public virtual DateTime dataentrada { get; set; }
        public virtual string proposta { get; set; }
        public virtual string obra { get; set; }
        public virtual string funcionario { get; set; }
        #endregion
    }
}
