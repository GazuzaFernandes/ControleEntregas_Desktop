using System;
using System.Collections.Generic;
using System.Text;

namespace DALLogistica.Entities
{
    public class Montagem
    {
        #region  Pasta - Sistema Amostra - Form Montagem de Amostra
        public virtual int MontagemId { get; set; }
        public virtual string Montador { get; set; }
        public virtual DateTime DataEnvio { get; set; }
        public virtual string Obra { get; set; }
        public virtual string Material { get; set; }
        public virtual int StatusobraId { get; set; }
        #endregion
    }
}
