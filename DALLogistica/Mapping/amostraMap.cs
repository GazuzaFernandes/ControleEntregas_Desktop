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
   public class AmostraMap : ClassMap<Amostra>
    {
        #region Pasta Sistema Amostra - Form Amostra
        public AmostraMap()
        {
            Id(p => p.AmostraId).GeneratedBy.Sequence("amostraa_seq");
            Map(p => p.Construtora);
            Map(p => p.DataEntrega);
            Map(p => p.Obra);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("amostra");
        }
        #endregion

    }
}
