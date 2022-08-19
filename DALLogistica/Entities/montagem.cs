using System;
using System.Collections.Generic;
using System.Text;

namespace DALLogistica.Entities
{
    public class Montagem
    {
        #region  Pasta - Sistema Amostra - Form Montagem de Amostra
        public virtual int montagemid { get; set; }
        public virtual string montador { get; set; }
        public virtual DateTime dataenvio { get; set; }
        public virtual string obra { get; set; }
        public virtual string material { get; set; }
        public virtual int statusobraid { get; set; }
        #endregion
    }
}
