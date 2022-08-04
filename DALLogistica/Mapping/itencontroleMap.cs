using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
    public class itencontroleMap : ClassMap<itencontrole>
    {
        #region Pasta - Sistema Logistica -  Form Saida Estoque
        public itencontroleMap()
        {
            Id(p => p.itencontroleid).GeneratedBy.Sequence("itencontrole_seq");
            Map(p => p.codigo);
            Map(p => p.material);
            Map(p => p.undmedida);
            Map(p => p.qtdcaixas);
            Map(p => p.qtdsaida);
            Map(p => p.controleid);
            Table("itencontrole");
        }
        #endregion
    }
}
