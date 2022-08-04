using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class infomaterial
    {
        #region  Pasta - Sistema Logistica - Form Material
        public virtual int materialid { get; set; }
        public virtual string material { get; set; }
        public virtual string utilidade { get; set; }
        #endregion
    }
}

