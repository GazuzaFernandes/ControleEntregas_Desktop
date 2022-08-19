using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class InfoMaterialMap : ClassMap<InfoMaterial>
    {
        #region Pasta - Sistema Logistica - Form Material
        public InfoMaterialMap()
        {
            Id(p => p.materialid).GeneratedBy.Sequence("infomaterial_seq");
            Map(p => p.material);
            Map(p => p.utilidade);
            Table("InfoMaterial");
        }
        #endregion
    }
}
