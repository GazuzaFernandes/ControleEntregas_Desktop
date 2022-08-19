using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class PropostaMap : ClassMap<Proposta>
    {
        #region Pasta Sistema Logistica - Form Proposta
        public PropostaMap()
        {
            Id(p => p.propostaid).GeneratedBy.Sequence("proposta_seq");
            Map(p => p.dataprevista);
            Map(p => p.fabrica);
            Map(p => p.datapedido);
            Map(p => p.faturado);
            Map(p => p.formapag);
            Map(p => p.engresp);
            Map(p => p.telefone);
            Map(p => p.pdrb);
            Map(p => p.pdvenda);
            Map(p => p.propostaa);
            Map(p => p.construtora);
            Map(p => p.material);
            Map(p => p.obra);
            Map(p => p.comentario);
            Map(p => p.dataentrega);
            Map(p => p.recebidopor);
            Map(p => p.notafiscal);
            Map(p => p.carreto);
            Map(p => p.statusobraid);
            Table("proposta");
        }
        #endregion
    }
}
