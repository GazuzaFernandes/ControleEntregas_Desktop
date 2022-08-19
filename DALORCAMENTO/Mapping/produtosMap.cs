using DALOrcamento.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrcamento.Mapping
{
    public class ProdutosMap : ClassMap<Produtos>
    {
        public ProdutosMap()
        {
            Id(p => p.produtoid).GeneratedBy.Sequence("produtos_seq");
            Map(p => p.fornecedor);
            Map(p => p.produto);
            Map(p => p.preco);
            Map(p => p.rendimento);
            Map(p => p.comentario);
            Table("produtos");
        }
    }
}
