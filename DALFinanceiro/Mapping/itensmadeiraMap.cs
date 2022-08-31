using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Mapping
{
    public class ItensmadeiraMap : ClassMap<Itensmadeira>
    {
        public ItensmadeiraMap()
        {
            Id(p => p.IdMadeira).GeneratedBy.Sequence("itensmadeira_seq");
            Map(p => p.Codigo);
            Map(p => p.Madeiras);
            Map(p => p.Medida);
            Map(p => p.Total);
     
            Map(p => p.IdProp);            
            Table("itensmadeira");
        }

    }
}
