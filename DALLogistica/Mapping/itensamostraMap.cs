using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensAmostraMap : ClassMap<ItensAmostra>
    {
        #region Pasta - Sistema Amostra - Form Amostra
        public ItensAmostraMap()
        {
            Id(p => p.ItensamostraId).GeneratedBy.Sequence("itensamostra_seq");
            Map(p => p.Codigo);
            Map(p => p.Material);
            Map(p => p.Quantidade);
            Map(p => p.Observacao);
            Map(p => p.AmostraId);
            Table("itensamostra");
        }
        #endregion
    }
}
