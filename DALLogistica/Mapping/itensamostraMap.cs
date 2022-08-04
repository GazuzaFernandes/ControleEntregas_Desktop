using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class itensamostraMap : ClassMap<itensamostra>
    {
        #region Pasta - Sistema Amostra - Form Amostra
        public itensamostraMap()
        {
            Id(p => p.itensamostraid).GeneratedBy.Sequence("itensamostra_seq");
            Map(p => p.codigo);
            Map(p => p.material);
            Map(p => p.quantidade);
            Map(p => p.observacao);
            Map(p => p.amostraid);
            Table("itensamostra");
        }
        #endregion
    }
}
