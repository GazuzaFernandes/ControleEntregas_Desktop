using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLmontagem : Repository<montagem>
    {
        #region Pasta - Sistema Amostra - Form Montagem de Amostra
        public List<MontageViewModel> ListarMontagem()
        {
            try
            {
                var lstMontagem = new List<MontageViewModel>();
                var ListarMntagem = new DLmontagem().Listar();
                var listaStatus = new DLstatusobra().Listar();

                var resultado = ListarMntagem
                   .Join(listaStatus, montagem => montagem.statusobraid, statuss => statuss.StatusObraId, (montagem, stattuss) => new { montagem, stattuss })
                   .Select(x => new MontageViewModel()
                   {
                       montagemid = x.montagem.montagemid,
                       montador = x.montagem.montador,
                       dataenvio = x.montagem.dataenvio,
                       obra = x.montagem.obra,
                       material = x.montagem.material,
                       Status = x.stattuss.Descricao,
                   }).ToList();
                foreach (var montagemcli in resultado)
                {

                    switch (montagemcli.Status)
                    {
                        case "Pedente":
                            montagemcli.OrdenacaoStatus = 2;
                            break;
                        case "Finalizado":
                            montagemcli.OrdenacaoStatus = 3;
                            break;
                        case "Cancelado":
                            montagemcli.OrdenacaoStatus = 4;
                            break;
                    }

                    lstMontagem.Add(montagemcli);
                }
                return lstMontagem.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public class MontageViewModel
        {
            public virtual int montagemid { get; set; }
            public virtual string montador { get; set; }
            public virtual DateTime dataenvio { get; set; }
            public virtual string obra { get; set; }
            public virtual string material { get; set; }
            public virtual int statusobraid { get; set; }
            public virtual int OrdenacaoStatus { get; set; }
            public string Status { get; set; }


        }
        #endregion
    }

}
