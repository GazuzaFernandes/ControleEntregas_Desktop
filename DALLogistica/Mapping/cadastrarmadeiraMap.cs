using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class CadastrarMadeiraMap : ClassMap<CadastrarMadeira>
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Intens
        public CadastrarMadeiraMap()
        {
            Id(p => p.madeiraid).GeneratedBy.Sequence("cadastromadeira_seq");
            Map(p => p.pisomadeira);       
            Map(p => p.m2caixa);
            Table("cadastrarmadeira");
        }
        #endregion
    }
}

 

