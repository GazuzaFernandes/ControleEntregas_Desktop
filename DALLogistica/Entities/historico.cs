using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class Historico
    {
        #region Pasta - Sistema Logistica -  Form Logistica
        public virtual int HistoricoId { get; set; }
        public virtual DateTime DataComentario { get; set; }
        public virtual string Comentario { get; set; }
        public virtual int PropostaId { get; set; }
        #endregion
    }
}
