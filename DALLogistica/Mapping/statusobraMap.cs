using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class StatusObraMap : ClassMap<StatusObra>
    {
        public StatusObraMap()
        {
            Id(p => p.StatusObraId);
            Map(p => p.Descricao);
            Table("statusobra");
        }
    }
}
