using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class InfoMaterial
    {
        #region  Pasta - Sistema Logistica - Form Material
        public virtual int MaterialId { get; set; }
        public virtual string Material { get; set; }
        public virtual string Utilidade { get; set; }
        #endregion
    }
}

