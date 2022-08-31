using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class ItensdataMap : ClassMap<Itensdata>
    {
        public ItensdataMap()
        {
            Id(p => p.IdDatas).GeneratedBy.Sequence("itensdata_seq");
            Map(p => p.Fabrica);
            Map(p => p.Datas);
            Map(p => p.IdMadeiras);
            Map(p => p.IdMaterial);          
            Map(p => p.Entrada);
            Table("itensdata");
        }

    }
}
