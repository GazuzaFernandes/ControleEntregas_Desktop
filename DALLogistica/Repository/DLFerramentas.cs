using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLFerramentas : Repository<Ferramentas>
    {
        #region Pasta - Sistema Logistica - Form Ferramentas
        public List<Ferramentasview> Listarferramenta()
        {
            try
            {
                var lstferramenta = new List<Ferramentasview>();

                var listarferramentas = new DLFerramentas().Listar();
                var listaStatus = new DLStatusObra().Listar();

                var resultado = listarferramentas
                   .Join(listaStatus, ferramentas => ferramentas.statusobraid, statuss => statuss.StatusObraId, (ferramentas, stattuss) => new { ferramentas, stattuss })
                   .Select(x => new
                   {
                       x.ferramentas.ferramentaid,
                       x.ferramentas.retirada,
                       x.ferramentas.devolucao,
                       x.ferramentas.funcionario,
                       x.ferramentas.material,
                       x.stattuss.Descricao,
                   }).ToList();


                foreach (var ferramentaclie in resultado)
                {
                    var ferra = new Ferramentasview();

                    ferra.ferramentaid = ferramentaclie.ferramentaid;
                    ferra.retirada = ferramentaclie.retirada;
                    ferra.devolucao = ferramentaclie.devolucao;
                    ferra.funcionario = ferramentaclie.funcionario;
                    ferra.material = ferramentaclie.material;
                    ferra.Status = ferramentaclie.Descricao;

                    switch (ferra.Status)
                    {
                        case "Pedente":
                            ferra.OrdenacaoStatus = 2;
                            break;
                        case "Finalizado":
                            ferra.OrdenacaoStatus = 3;
                            break;
                    }

                    lstferramenta.Add(ferra);
                }

                return lstferramenta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public class Ferramentasview
        {
            public virtual int ferramentaid { get; set; }
            public virtual string funcionario { get; set; }
            public virtual DateTime retirada { get; set; }
            public virtual DateTime devolucao { get; set; }
            public virtual string material { get; set; }
            public virtual int statusobraid { get; set; }
            public virtual int OrdenacaoStatus { get; set; }
            public string Status { get; set; }

        }
        #endregion
    }
}
