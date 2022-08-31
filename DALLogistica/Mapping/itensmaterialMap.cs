using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensMaterialMap : ClassMap<ItensMaterial>
    {
        #region Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public ItensMaterialMap()
        {
            Id(p => p.MaterialId).GeneratedBy.Sequence("itensmaterial_seq");
            Map(p => p.Material);
            Map(p => p.Quantidade);
            Map(p => p.UnidadeMedida);
            Map(p => p.Entrada);
            Map(p => p.Total);
            Table("itensmaterial");
        }
        #endregion
    }
}
