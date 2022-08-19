using DALOrcamento.Entities;
using FluentNHibernate.Mapping;

namespace DALOrcamento.Mapping
{
    class DataprodutoMap : ClassMap<DataProduto>
    {
        public DataprodutoMap()
        {
            Id(p => p.dataid).GeneratedBy.Sequence("dataproduto_seq");
            Map(p => p.data);
            Map(p => p.preco);           
            Map(p => p.produtoid);            
            Table("dataproduto");
        }
    }
}
