using DALSenhas.Entities;

using FluentNHibernate.Mapping;

namespace DALSenhas.Mapping
{
    public class SenhassMap : ClassMap<Senhass>
    {
        public SenhassMap()
        {
            Id(p => p.usuarioid);           
            Map(p => p.senhass);
            Table("senhass");
        }
    }
}
