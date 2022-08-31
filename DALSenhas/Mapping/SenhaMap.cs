using DALSenhas.Entities;

using FluentNHibernate.Mapping;

namespace DALSenhas.Mapping
{
    public class SenhaMap : ClassMap<Senha>
    {
        public SenhaMap()
        {
            Id(p => p.UsuarioId);           
            Map(p => p.Senhas);
            Table("senha");
        }
    }
}
