using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Mapping
{
    public class itensmadeiraMap : ClassMap<itensmadeira>
    {
        public itensmadeiraMap()
        {
            Id(p => p.idmadeira).GeneratedBy.Sequence("itensmadeira_seq");
            Map(p => p.codigo);
            Map(p => p.madeiras);
            Map(p => p.medida);
            Map(p => p.total);
     
            Map(p => p.idprop);            
            Table("itensmadeira");
        }

    }
}
