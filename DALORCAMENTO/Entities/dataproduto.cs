using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrcamento.Entities
{
    public class DataProduto
    {
        public virtual int dataid { get; set; }
        public virtual DateTime data { get; set; }
        public virtual string preco { get; set; }
        public virtual int produtoid { get; set; }
       
    }
}
