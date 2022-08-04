using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class FerramentasMap : ClassMap<Ferramentas>
    {
        #region Pasta - Sistema Logistica - Form Ferramentas
        public FerramentasMap()
        {
            Id(p => p.ferramentaid).GeneratedBy.Sequence("ferramentas_seq");
            Map(p => p.funcionario);
            Map(p => p.retirada);
            Map(p => p.devolucao);
            Map(p => p.material);
            Map(p => p.statusobraid);
            Table("Ferramentas");
        }
        #endregion
    }
}
