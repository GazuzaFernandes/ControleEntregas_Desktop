using DALFinanceiro.Entities;
using FluentNHibernate.Mapping;

namespace DALFinanceiro.Mapping
{
    public class MadeiraMap :ClassMap<Madeira>
    {
        public MadeiraMap()
        {
            Id(p => p.idmadeiras).GeneratedBy.Sequence("madeira_seq");
            Map(p => p.fabrica);
            Map(p => p.madeiras);
            Map(p => p.unidademedida);
            Map(p => p.entrada);
            Map(p => p.datas);
            Map(p => p.total);           
            Map(p => p.comentario);
            Map(p => p.rbcomercio);
            Map(p => p.rbengenharia);
            Map(p => p.rbpisos);
            Map(p => p.codigo);
            Map(p => p.madeirasaida);
            Map(p => p.unidademedidaSaida);
            Map(p => p.saida);
            Map(p => p.totalsaida);            
            Map(p => p.statusobraid);
            Table("madeira");
        }
    }
}
