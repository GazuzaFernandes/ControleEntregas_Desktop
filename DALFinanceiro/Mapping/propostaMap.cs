using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class PropostaMap : ClassMap<Proposta>
    {
        public PropostaMap()
        {
            Id(p => p.IdProp).GeneratedBy.Sequence("proposta_seq");
            Map(p => p.EmissaoNf);
            Map(p => p.VencimentoNf);
            Map(p => p.Cliente);           
            Map(p => p.Propostas);
            Map(p => p.Notafiscal);
            Map(p => p.Obra);
            Map(p => p.Email);
            Map(p => p.Cometario);
            Map(p => p.StatusobraId);       
            Table("proposta");
        }
    }
}
