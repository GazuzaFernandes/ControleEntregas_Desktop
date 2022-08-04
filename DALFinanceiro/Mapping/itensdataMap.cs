using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class itensdataMap : ClassMap<itensdata>
    {
        public itensdataMap()
        {
            Id(p => p.iddatas).GeneratedBy.Sequence("itensdata_seq");
            Map(p => p.fabrica);
            Map(p => p.datas);
            Map(p => p.idmadeiras);
            Map(p => p.idmaterial);
          
            Map(p => p.entrada);
            Table("itensdata");
        }

    }
}
