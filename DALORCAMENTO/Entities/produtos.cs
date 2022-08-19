using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrcamento.Entities
{
    public class Produtos
    {
        public virtual int produtoid { get; set; }
        public virtual string fornecedor { get; set; }
        public virtual string produto { get; set; }
        public virtual string preco { get; set; }
        public virtual string rendimento { get; set; }
        public virtual string comentario { get; set; }
    }
}
