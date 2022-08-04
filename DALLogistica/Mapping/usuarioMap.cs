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
            Map(p => p.DataAlteracao);
            Map(p => p.Login);
            Map(p => p.Nome);
            Map(p => p.Senha);
            Table("Usuario");
        }
    }
}
