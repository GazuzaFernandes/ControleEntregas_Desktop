using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensAmostraMap : ClassMap<ItensAmostra>
    {
        #region Pasta - Sistema Amostra - Form Amostra
        public ItensAmostraMap()
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
