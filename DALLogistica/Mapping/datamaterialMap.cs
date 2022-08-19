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
            Id(p => p.dataid).GeneratedBy.Sequence("datamaterial_seq");
            Map(p => p.dataentrada);
            Map(p => p.entrada);
            Map(p => p.fabrica);
            Map(p => p.obra);
            Map(p => p.materialid);
            Table("datamaterial");
        }
        #endregion
    }
}
