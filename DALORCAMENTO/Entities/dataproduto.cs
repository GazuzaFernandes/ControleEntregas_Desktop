using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrcamento.Entities
{
    public class DataProduto
    {
        public virtual int DataId { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual string Preco { get; set; }
        public virtual int ProdutoId { get; set; }       
    }
}
