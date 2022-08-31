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
        public virtual int DataId { get; set; }
        public virtual DateTime DataEntrada { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual string Fabrica { get; set; }
        public virtual string Obra { get; set; }
        public virtual int MaterialId { get; set; }
        #endregion
    }
}
