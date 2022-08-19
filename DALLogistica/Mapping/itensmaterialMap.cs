using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensMaterialMap : ClassMap<ItensMaterial>
    {
        #region Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public ItensMaterialMap()
        {
            Id(p => p.materialid).GeneratedBy.Sequence("itensmaterial_seq");
            Map(p => p.material);
            Map(p => p.quantidade);
            Map(p => p.unidademedida);
            Map(p => p.entrada);
            Map(p => p.total);
            Table("itensmaterial");
        }
        #endregion
    }
}
