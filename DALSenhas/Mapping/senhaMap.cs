using DALSenhas.Entities;

using FluentNHibernate.Mapping;

namespace DALSenhas.Mapping
{
    public class senhaMap : ClassMap<senha>
    {
        public senhaMap()
        {
            Id(p => p.usuarioid);           
            Map(p => p.senhass);
            Table("senha");
        }
    }
}
