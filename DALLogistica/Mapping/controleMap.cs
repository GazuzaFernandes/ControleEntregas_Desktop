using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
  public  class controleMap : ClassMap<controle>
    {
        #region Pasta - Sistema Logistica - Form Saida Estoque
        public controleMap()
        {
            Id(p => p.controleid).GeneratedBy.Sequence("controle_seq");
            Map(p => p.proposta);
            Map(p => p.obra);
            Map(p => p.dataentrada);
            Map(p => p.funcionario);
            Table("controle");
        }
        #endregion
    }
}
