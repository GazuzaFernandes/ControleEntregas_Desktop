using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class MontagemMap : ClassMap<Montagem>
    {
        #region Pasta - Sistema Amostra - Form Montagem de Amostra
        public MontagemMap()
        {
            Id(p => p.MontagemId).GeneratedBy.Sequence("montagem_seq");
            Map(p => p.Montador);
            Map(p => p.DataEnvio);
            Map(p => p.Obra);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("montagem");
        }
        #endregion
    }
}
