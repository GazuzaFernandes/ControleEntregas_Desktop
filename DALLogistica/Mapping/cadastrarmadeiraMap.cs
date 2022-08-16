using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class cadastrarmadeiraMap : ClassMap<cadastrarmadeira>
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Intens
        public cadastrarmadeiraMap()
        {
            Id(p => p.madeiraid).GeneratedBy.Sequence("cadastromadeira_seq");
            Map(p => p.pisomadeira);
            Map(p => p.comprimentos);
            Map(p => p.m2caixa);
            Table("cadastrarmadeira");
        }
        #endregion
    }
}

 

