using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class Controle
    {
        #region Pasta - Sistema Logistica - Form Saida Estoque
        public virtual int ControleId { get; set; }
        public virtual DateTime DataEntrada { get; set; }
        public virtual string Proposta { get; set; }
        public virtual string Obra { get; set; }
        public virtual string Funcionario { get; set; }
        #endregion
    }
}
