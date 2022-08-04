using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLamostracliente : Repository<amostracliente>
    {
        #region Pasta - Sistema Amostra -  Form Amostra Cliente
        public List<AmostraclienteViewModel> ListarAmostraclienteStatus()
        {
            try
            {
                var lstAamostracliente = new List<AmostraclienteViewModel>();

                var listaAamostracliente = new DLamostracliente().Listar();
                var listaStatus = new DLstatusobra().Listar();

                var resultado = listaAamostracliente
                   .Join(listaStatus, amostracliente => amostracliente.statusobraid, statuss => statuss.StatusObraId, (amostracliente, stattuss) => new { amostracliente, stattuss })
                   .Select(x => new
                   {
                       x.amostracliente.amostraid,
                       x.amostracliente.construtora,
                       x.amostracliente.dataentrega,
                       x.amostracliente.obra,
                       x.amostracliente.material,
                       x.stattuss.Descricao,
                   }).ToList();


                foreach (var amostracliente in resultado)
                {
                    var amoclie = new AmostraclienteViewModel();

                    amoclie.amostraid = amostracliente.amostraid;
                    amoclie.construtora = amostracliente.construtora;
                    amoclie.dataentrega = amostracliente.dataentrega;
                    amoclie.obra = amostracliente.obra;
                    amoclie.material = amostracliente.material;

                    amoclie.Status = amostracliente.Descricao;

                    switch (amoclie.Status)
                    {
                        case "Pedente":
                            amoclie.OrdenacaoStatus = 2;
                            break;
                        case "Finalizado":
                            amoclie.OrdenacaoStatus = 3;
                            break;
                        case "Cancelado":
                            amoclie.OrdenacaoStatus = 4;
                            break;

                    }

                    lstAamostracliente.Add(amoclie);
                }

                return lstAamostracliente.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public class AmostraclienteViewModel
        {
            public virtual int amostraid { get; set; }
            public virtual string construtora { get; set; }
            public virtual DateTime dataentrega { get; set; }
            public virtual string obra { get; set; }
            public virtual int statusobra { get; set; }
            public virtual string material { get; set; }
            public virtual int OrdenacaoStatus { get; set; }
            public string Status { get; set; }


        }
        #endregion
    }

}
