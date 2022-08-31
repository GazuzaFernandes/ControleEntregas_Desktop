using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class AmostraClienteMap : ClassMap<AmostraCliente>
    {
        #region  Pasta - Sistema Amostra -  Form Amostra Cliente
        public AmostraClienteMap()
        {
            Id(p => p.AmostraId).GeneratedBy.Sequence("amostracliente_seq");
            Map(p => p.Construtora);
            Map(p => p.DataEntrega);
            Map(p => p.Obra);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("amostracliente");
        }
        #endregion
    }
}
