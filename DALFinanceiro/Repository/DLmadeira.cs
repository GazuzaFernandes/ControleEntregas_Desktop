using DALFinanceiro.Entities;
using DALFinanceiro.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALFinanceiro.Repository
{
    public class DLMadeira : Repository<Madeira>
    {
        public List<PropostaViewModel> ListarMadeiraStatus()
        {
            try
            {
                var lstmadeira = new List<PropostaViewModel>();
                var listarmadeiras = new DLMadeira().Listar();
                var listaStatus = new DLStatusobra().Listar();

                var resultado = listarmadeiras
               .Join(listaStatus, madeira => madeira.statusobraid, statuss => statuss.StatusObraId, (madeira, stattuss) => new { madeira, stattuss })
                .Select(x => new PropostaViewModel()
                {
                    idmadeiras = x.madeira.idmadeiras,
                    fabrica = x.madeira.fabrica,
                    madeiras = x.madeira.madeiras,
                    unidademedida = x.madeira.unidademedida,
                    total = x.madeira.total,
                    entrada = x.madeira.entrada,
                    comentario = x.madeira.comentario,
                    rbcomercio = x.madeira.rbcomercio,
                    rbengenharia = x.madeira.rbengenharia,
                    rbpisos = x.madeira.rbpisos,
                    codigo = x.madeira.codigo,
                    madeirasaida = x.madeira.madeirasaida,
                    totalsaida = x.madeira.totalsaida,
                    saida = x.madeira.saida,
                    unidademedidaSaida = x.madeira.unidademedidaSaida,
                    Status = x.stattuss.Descricao,
                }).ToList();

                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
                        case "RbEngenharia":
                            proposta.OrdenacaoStatus = 1;
                            break;
                        case "RbComercio":
                            proposta.OrdenacaoStatus = 2;
                            break;
                        case "RbPisos":
                            proposta.OrdenacaoStatus = 3;
                            break;
                    }
                    lstmadeira.Add(proposta);
                }
                return lstmadeira.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public class PropostaViewModel
        {
            public virtual int idmadeiras { get; set; }
            public virtual string fabrica { get; set; }
            public virtual string madeiras { get; set; }
            public virtual string unidademedida { get; set; }
            public virtual decimal entrada { get; set; }
            public virtual DateTime datas { get; set; }
            public virtual decimal total { get; set; }
            public virtual string comentario { get; set; }
            public virtual int rbcomercio { get; set; }
            public virtual int rbengenharia { get; set; }
            public virtual int rbpisos { get; set; }
            public virtual int codigo { get; set; }
            public virtual string madeirasaida { get; set; }
            public virtual string unidademedidaSaida { get; set; }
            public virtual decimal saida { get; set; }
            public virtual decimal retirada { get; set; }
            public string Status { get; set; }
            public virtual decimal totalsaida { get; set; }
            public virtual int statusobraid { get; set; }
            public int OrdenacaoStatus { get; set; }


        }

    }
}
