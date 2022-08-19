using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class MontagemMap : ClassMap<Montagem>
    {
        #region Pasta - Sistema Amostra - Form Montagem de Amostra
        public MontagemMap()
        {
            Id(p => p.montagemid).GeneratedBy.Sequence("montagem_seq");
            Map(p => p.montador);
            Map(p => p.dataenvio);
            Map(p => p.obra);
            Map(p => p.material);
            Map(p => p.statusobraid);
            Table("montagem");
        }
        #endregion
    }
}
