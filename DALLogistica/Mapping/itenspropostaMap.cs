using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensPropostaMap : ClassMap<ItensProposta>
    {
        #region Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public ItensPropostaMap()
        {
            Id(p => p.ItenId).GeneratedBy.Sequence("itenproposta_seq");
            Map(p => p.Material);
            Map(p => p.ObsMaterial);
            Map(p => p.Quantidade);
            Map(p => p.Preco);
            Map(p => p.Total);
            Map(p => p.M2NotaFiscal);
            Map(p => p.UndMedida);            
            Map(p => p.M2caixa);
            Map(p => p.PropostaId);
            Map(p => p.CodigoMaterial);
            Table("itensproposta");
        }
        #endregion
    }
}
