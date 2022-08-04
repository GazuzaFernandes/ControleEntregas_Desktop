using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
   public class historicoMap : ClassMap<historico>
    {
        #region  Pasta - Sistema Logistica -  Form Logistica
        public historicoMap()
        {
            Id(p => p.historicoid).GeneratedBy.Sequence("historico_seq");
            Map(p => p.datacomentario);
            Map(p => p.comentario);
           
            Map(p => p.propostaid);         
            Table("historico");
        }
        #endregion
    }
}
