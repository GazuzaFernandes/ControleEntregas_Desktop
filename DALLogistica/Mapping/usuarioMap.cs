using DALLogistica.Entities;

using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class usuarioMap : ClassMap<usuario>
    {
        public usuarioMap()
        {
            Id(p => p.UsuarioId);
            Map(p => p.Ativo);          
            Map(p => p.Senha);
            Table("Usuario");
        }
    }
}
