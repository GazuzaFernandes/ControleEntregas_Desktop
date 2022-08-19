using DALSenhas.Entities;

using FluentNHibernate.Mapping;

namespace DALSenhas.Mapping
{
    public class SenhaMap : ClassMap<Senha>
    {
        public SenhaMap()
        {
            Id(p => p.usuarioid);           
            Map(p => p.senhass);
            Table("senha");
        }
    }
}
