using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class RegraMaterialMap : ClassMap<RegraMaterial>
    {
        #region Pasta - Sistema Logistica - Form de Nota Fiscal
        public RegraMaterialMap()
        {
            Id(p => p.RegrasId).GeneratedBy.Sequence("regras_seq");
            Map(p => p.Material);
            Map(p => p.Codigo);
            Map(p => p.Ncm);
            Map(p => p.CstSaida);
            Map(p => p.Tributos);
            Map(p => p.CfopSaidaSp);
            Map(p => p.CfopSaidaoutrosufPj);
            Map(p => p.CfopSaidaoutrosufPf);
            Table("regramaterial");
        }
        #endregion
    }
}
