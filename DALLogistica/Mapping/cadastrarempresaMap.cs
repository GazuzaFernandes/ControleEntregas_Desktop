using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class CadastrarEmpresaMap : ClassMap<CadastrarEmpresa>
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Empresa
        public CadastrarEmpresaMap()
        {
            Id(p => p.empresaid).GeneratedBy.Sequence("cadastrarempresa_seq");
            Map(p => p.empresa);
            Table("cadastrarempresa");
        }
        #endregion
    }
}
