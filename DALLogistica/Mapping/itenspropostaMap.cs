﻿using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class itenspropostaMap : ClassMap<itensproposta>
    {
        #region Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public itenspropostaMap()
        {
            Id(p => p.itenid).GeneratedBy.Sequence("itenproposta_seq");
            Map(p => p.material);
            Map(p => p.obsmaterial);
            Map(p => p.quantidade);
            Map(p => p.preco);
            Map(p => p.total);
            Map(p => p.m2notafiscal);
            Map(p => p.undmedida);
            
            Map(p => p.m2caixa);
            Map(p => p.propostaid);
            Map(p => p.codigomaterial);
            Table("itensproposta");
        }
        #endregion
    }
}
