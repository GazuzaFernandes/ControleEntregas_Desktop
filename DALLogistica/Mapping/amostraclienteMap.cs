using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class amostraclienteMap : ClassMap<amostracliente>
    {
        #region  Pasta - Sistema Amostra -  Form Amostra Cliente
        public amostraclienteMap()
        {
            Id(p => p.amostraid).GeneratedBy.Sequence("amostracliente_seq");
            Map(p => p.construtora);
            Map(p => p.dataentrega);
            Map(p => p.obra);
            Map(p => p.material);
            Map(p => p.statusobraid);

            Table("amostracliente");
        }
        #endregion
    }
}
