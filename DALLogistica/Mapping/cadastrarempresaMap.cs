using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class cadastrarempresaMap : ClassMap<cadastrarempresa>
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Empresa
        public cadastrarempresaMap()
        {
            Id(p => p.empresaid).GeneratedBy.Sequence("cadastrarempresa_seq");
            Map(p => p.empresa);
            Table("cadastrarempresa");
        }
        #endregion
    }
}
