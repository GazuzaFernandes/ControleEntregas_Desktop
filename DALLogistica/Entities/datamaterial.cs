using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
   public class DataMaterial
    {
        #region Pasta Sistema Logistica - Form Estoque
        public virtual int dataid { get; set; }
        public virtual DateTime dataentrada { get; set; }
        public virtual decimal entrada { get; set; }
        public virtual string fabrica { get; set; }
        public virtual string obra { get; set; }
        public virtual int materialid { get; set; }
        #endregion
    }
}
