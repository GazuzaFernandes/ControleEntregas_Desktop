using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
    public class ItenControleMap : ClassMap<ItenControle>
    {
        #region Pasta - Sistema Logistica -  Form Saida Estoque
        public ItenControleMap()
        {
            Id(p => p.ItencontroleId).GeneratedBy.Sequence("itencontrole_seq");
            Map(p => p.Codigo);
            Map(p => p.Material);
            Map(p => p.UndMedida);
            Map(p => p.QtdCaixas);
            Map(p => p.QtdSaida);
            Map(p => p.ControleId);
            Table("itencontrole");
        }
        #endregion
    }
}
