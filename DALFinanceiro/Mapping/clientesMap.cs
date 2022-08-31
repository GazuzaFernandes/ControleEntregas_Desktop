using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class ClientesMap : ClassMap<Clientes>
    {
        public ClientesMap()
        {
            Id(p => p.IdCliente).GeneratedBy.Sequence("cliente_seq");
            Map(p => p.Nome);
                  
            Table("clientes");
        }

    }
}
