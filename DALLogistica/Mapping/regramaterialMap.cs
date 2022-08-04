using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class regramaterialMap : ClassMap<regramaterial>
    {
        #region Pasta - Sistema Logistica - Form de Nota Fiscal
        public regramaterialMap()
        {
            Id(p => p.regrasid).GeneratedBy.Sequence("regras_seq");
            Map(p => p.material);
            Map(p => p.codigo);
            Map(p => p.ncm);
            Map(p => p.cstsaida);
            Map(p => p.tributos);
            Map(p => p.cfopsaidasp);
            Map(p => p.cfopsaidaoutrosufpj);
            Map(p => p.cfopsaidaoutrosufpf);
            Table("regramaterial");
        }
        #endregion
    }
}
