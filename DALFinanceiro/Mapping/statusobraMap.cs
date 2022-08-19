using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class StatusobraMap : ClassMap<Statusobra>
    {
        public StatusobraMap()
        {
            Id(p => p.StatusObraId);
            Map(p => p.Descricao);
            Table("statusobra");
        }
    }
}
