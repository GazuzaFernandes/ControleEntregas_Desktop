using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class PropostaMap : ClassMap<Proposta>
    {
        #region Pasta Sistema Logistica - Form Proposta
        public PropostaMap()
        {
            Id(p => p.PropostaId).GeneratedBy.Sequence("proposta_seq");
            Map(p => p.DataPrevista);
            Map(p => p.Fabrica);
            Map(p => p.DataPedido);
            Map(p => p.Faturado);
            Map(p => p.FormaPag);
            Map(p => p.EngResp);
            Map(p => p.Telefone);
            Map(p => p.PdRb);
            Map(p => p.PdVenda);
            Map(p => p.Propostaa);
            Map(p => p.Construtora);
            Map(p => p.Material);
            Map(p => p.Obra);
            Map(p => p.Comentario);
            Map(p => p.DataEntrega);
            Map(p => p.RecebidoPor);
            Map(p => p.NotaFiscal);
            Map(p => p.Carreto);
            Map(p => p.StatusobraId);
            Table("proposta");
        }
        #endregion
    }
}
