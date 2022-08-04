using DALFinanceiro.Entities;
using DALFinanceiro.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALFinanceiro.Repository
{
    public class DLproposta : Repository<proposta>
    {
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLproposta().Listar();
                var listaStatus = new DLstatusobra().Listar();

                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.statusobraid, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       idprop = x.proposta.idprop,
                       emissaonf = x.proposta.emissaonf,
                       vencimentonf = x.proposta.vencimentonf,
                       cliente = x.proposta.cliente,
                       email = x.proposta.email,
                       propostas = x.proposta.propostas,
                       notafiscal = x.proposta.notafiscal,
                       obra = x.proposta.obra,
                       cometario = x.proposta.cometario,
                       Status = x.stattuss.Descricao,
                       rbcomercio = x.proposta.rbcomercio,
                       rbengenharia = x.proposta.rbengenharia,
                       rbpisos = x.proposta.rbpisos,

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
                    lstProposta.Add(proposta);
                }
                return lstProposta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
    public class PropostaViewModel
    {
        public virtual int idprop { get; set; }
        public virtual DateTime emissaonf { get; set; }
        public virtual DateTime vencimentonf { get; set; }
        public virtual string cliente { get; set; }
        public virtual string email { get; set; }
        public virtual string propostas { get; set; }
        public virtual string notafiscal { get; set; }
        public virtual string obra { get; set; }
        public virtual string cometario { get; set; }
        public virtual int statusobra { get; set; }
        public virtual int rbcomercio { get; set; }
        public virtual int rbengenharia { get; set; }
        public virtual int rbpisos { get; set; }
        public int OrdenacaoStatus { get; set; }
        public string Status { get; set; }
    }
}
