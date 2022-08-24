using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class ItensPropostaMap : ClassMap<ItensProposta>
    {
        #region Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public ItensPropostaMap()
        {
            Id(p => p.itenid).GeneratedBy.Sequence("itenproposta_seq");
            Map(p => p.material);
            Map(p => p.obsmaterial);
            Map(p => p.quantidade);
            Map(p => p.preco);
            Map(p => p.total);
            Map(p => p.metragemcaixa);
            Map(p => p.undmedida);            
            Map(p => p.m2caixa);
            Map(p => p.propostaid);
            Map(p => p.codigomaterial);
            Table("itensproposta");
        }
        #endregion
    }
}
