using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLProposta : Repository<Proposta>
    {
        #region Pasta - Sistema Logistica - Forme Proposta e Principal
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLProposta().Listar();
                var listaStatus = new DLStatusObra().Listar();
                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.StatusobraId, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       propostaid = x.proposta.PropostaId,
                       dataprevista = x.proposta.DataPrevista,
                       datapedido = x.proposta.DataPedido,
                       fabrica = x.proposta.Fabrica,
                       faturado = x.proposta.Faturado,
                       formapag = x.proposta.FormaPag,
                       engresp = x.proposta.EngResp,
                       telefone = x.proposta.Telefone,
                       pdrb = x.proposta.PdRb,
                       pdvenda = x.proposta.PdVenda,
                       propostaa = x.proposta.Propostaa,
                       construtora = x.proposta.Construtora,
                       obra = x.proposta.Obra,
                       comentario = x.proposta.Comentario,
                       dataentrega = x.proposta.DataEntrega,
                       Status = x.stattuss.Descricao,
                       material = x.proposta.Material,
                       recebidopor = x.proposta.RecebidoPor,
                       notafiscal = x.proposta.NotaFiscal,
                       carreto = x.proposta.Carreto,
                   }).ToList();
                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
                        case "Imediato":
                            proposta.OrdenacaoStatus = 1;
                            break;

                        case "Pendente":
                            proposta.OrdenacaoStatus = 2;
                            break;

                        case "Finalizado":
                            proposta.OrdenacaoStatus = 3;
                            break;

                        case "Cancelado":
                            proposta.OrdenacaoStatus = 4;
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
        public class PropostaViewModel
        {
          
            public virtual int propostaid { get; set; }
            public virtual DateTime dataprevista { get; set; }
            public virtual DateTime datapedido { get; set; }
            public virtual string fabrica { get; set; }
            public virtual string faturado { get; set; }
            public virtual string material { get; set; }
            public virtual string formapag { get; set; }
            public virtual string engresp { get; set; }
            public virtual string telefone { get; set; }
            public virtual string pdrb { get; set; }
            public virtual string pdvenda { get; set; }
            public virtual string propostaa { get; set; }
            public virtual string construtora { get; set; }
            public virtual string obra { get; set; }
            public virtual string comentario { get; set; }
            public virtual DateTime dataentrega { get; set; }
            public virtual string recebidopor { get; set; }
            public virtual string notafiscal { get; set; }
            public virtual string carreto { get; set; }
            public virtual int statusobraid { get; set; }
            public int OrdenacaoStatus { get; set; }
            public string Status { get; set; }
        }
        #endregion
    }

}
