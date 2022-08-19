using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class PropostaMap : ClassMap<Proposta>
    {
        public PropostaMap()
        {
            Id(p => p.idprop).GeneratedBy.Sequence("proposta_seq");
            Map(p => p.emissaonf);
            Map(p => p.vencimentonf);
            Map(p => p.cliente);
            Map(p => p.email);
            Map(p => p.propostas);
            Map(p => p.notafiscal);
            Map(p => p.obra);
            Map(p => p.cometario);
            Map(p => p.statusobraid);
            Map(p => p.rbcomercio);
            Map(p => p.rbengenharia);
            Map(p => p.rbpisos);
            Table("proposta");
        }
    }
}
