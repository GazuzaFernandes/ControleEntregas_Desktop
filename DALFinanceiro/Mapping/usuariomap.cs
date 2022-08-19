
using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class UsuarioMap
    {
        public class usuarioMap : ClassMap<Usuario>
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
}
