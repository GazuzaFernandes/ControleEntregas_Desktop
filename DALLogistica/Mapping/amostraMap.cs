using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
   public class amostraMap : ClassMap<amostra>
    {
        #region Pasta Sistema Amostra - Form Amostra
        public amostraMap()
        {
            Id(p => p.amostraid).GeneratedBy.Sequence("amostraa_seq");
            Map(p => p.construtora);
            Map(p => p.dataentrega);
            Map(p => p.obra);
            Map(p => p.material);
            Map(p => p.statusobraid);
            Table("amostra");
        }
        #endregion

    }
}
