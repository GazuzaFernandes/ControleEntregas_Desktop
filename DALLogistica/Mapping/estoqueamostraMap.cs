﻿using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
    public class EstoqueAmostraMap : ClassMap<EstoqueAmostra>
    {
        #region Pasta Sistema de Amostra - Form Estoque de Amostra
        public EstoqueAmostraMap()
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
