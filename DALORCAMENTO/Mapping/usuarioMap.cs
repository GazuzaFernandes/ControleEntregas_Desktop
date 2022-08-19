using DALOrcamento.Entities;

using FluentNHibernate.Mapping;

namespace DALOrcamento.Mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
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
