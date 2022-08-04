using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class clientesMap : ClassMap<clientes>
    {
        public clientesMap()
        {
            Id(p => p.idcliente).GeneratedBy.Sequence("cliente_seq");
            Map(p => p.nome);
                  
            Table("clientes");
        }

    }
}
