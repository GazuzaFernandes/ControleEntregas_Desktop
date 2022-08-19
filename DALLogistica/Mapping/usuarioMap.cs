using DALLogistica.Entities;

using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Id(p => p.UsuarioId);
            Map(p => p.Ativo);          
            Map(p => p.Senha);
            Table("Usuario");
        }
    }
}
