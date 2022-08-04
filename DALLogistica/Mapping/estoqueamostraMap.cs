using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
    public class estoqueamostraMap : ClassMap<estoqueamostra>
    {
        #region Pasta Sistema de Amostra - Form Estoque de Amostra
        public estoqueamostraMap()
        {
            Id(p => p.estoqueid).GeneratedBy.Sequence("estoqueamostra_seq");
            Map(p => p.amostra);
            Map(p => p.entrada);
            Map(p => p.total);
            Table("estoqueamostra");
        }
        #endregion
    }
}
