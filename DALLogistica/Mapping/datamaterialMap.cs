using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
  public  class DataMaterialMap : ClassMap<DataMaterial>
    {
        #region Pasta Sistema Logistica - Form Estoque
        public DataMaterialMap()
        {
            Id(p => p.DataId).GeneratedBy.Sequence("datamaterial_seq");
            Map(p => p.DataEntrada);
            Map(p => p.Entrada);
            Map(p => p.Fabrica);
            Map(p => p.Obra);
            Map(p => p.MaterialId);
            Table("datamaterial");
        }
        #endregion
    }
}
