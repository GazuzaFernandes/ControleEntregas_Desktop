using DALOrcamento.Entities;
using FluentNHibernate.Mapping;

namespace DALOrcamento.Mapping
{
    class dataprodutoMap : ClassMap<dataproduto>
    {
        public dataprodutoMap()
        {
            Id(p => p.dataid).GeneratedBy.Sequence("dataproduto_seq");
            Map(p => p.data);
            Map(p => p.preco);           
            Map(p => p.produtoid);            
            Table("dataproduto");
        }
    }
}
