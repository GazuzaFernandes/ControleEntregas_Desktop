using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class FerramentasMap : ClassMap<Ferramentas>
    {
        #region Pasta - Sistema Logistica - Form Ferramentas
        public FerramentasMap()
        {
            Id(p => p.FerramentaId).GeneratedBy.Sequence("ferramentas_seq");
            Map(p => p.Funcionario);
            Map(p => p.Retirada);
            Map(p => p.Devolucao);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("Ferramentas");
        }
        #endregion
    }
}
