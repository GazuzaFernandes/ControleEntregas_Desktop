using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class CadastrarMadeira
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Intens
        public virtual int MadeiraId { get; set; }
        public virtual string PisoMadeira { get; set; }     
        public virtual decimal M2Caixa { get; set; }
        #endregion

    }
}
