using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class statusobraMap : ClassMap<statusobra>
    {
        public statusobraMap()
        {
            Id(p => p.StatusObraId);
            Map(p => p.Descricao);
            Table("statusobra");
        }
    }
}
