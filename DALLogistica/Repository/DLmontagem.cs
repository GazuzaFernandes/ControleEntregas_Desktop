﻿using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLMontagem : Repository<Montagem>
    {
        #region Pasta - Sistema Amostra - Form Montagem de Amostra
        public List<MontageViewModel> ListarMontagem()
        {
            try
            {
                var lstMontagem = new List<MontageViewModel>();
                var ListarMntagem = new DLMontagem().Listar();
                var listaStatus = new DLStatusObra().Listar();

                var resultado = ListarMntagem
                   .Join(listaStatus, montagem => montagem.StatusobraId, statuss => statuss.StatusObraId, (montagem, stattuss) => new { montagem, stattuss })
                   .Select(x => new MontageViewModel()
                   {
                       montagemid = x.montagem.MontagemId,
                       montador = x.montagem.Montador,
                       dataenvio = x.montagem.DataEnvio,
                       obra = x.montagem.Obra,
                       material = x.montagem.Material,
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
