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
               .Join(listaStatus, madeira => madeira.StatusObraId, statuss => statuss.StatusObraId, (madeira, stattuss) => new { madeira, stattuss })
                .Select(x => new PropostaViewModel()
                {
                    IdMadeiras = x.madeira.IdMadeiras,
                    Madeiras = x.madeira.Madeiras,
                    UnidadeMedida = x.madeira.UnidadeMedida,
                    Total = x.madeira.Total,
                    Fabrica = x.madeira.Fabrica,                  
                    Entrada = x.madeira.Entrada,
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
            public virtual int IdMadeiras { get; set; }
            public virtual string Fabrica { get; set; }
            public virtual string Madeiras { get; set; }
            public virtual string UnidadeMedida { get; set; }
            public virtual decimal Entrada { get; set; }
            public virtual decimal Total { get; set; }
            public string Status { get; set; }
            public int OrdenacaoStatus { get; set; }


        }

    }
}
