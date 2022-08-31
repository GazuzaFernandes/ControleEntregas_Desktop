using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
   public class CadastrarEmpresa
    {
        #region Pasta - Sistema Logistica -  Form Cadastro Empresa
        public virtual int EmpresaId { get; set; }
        public virtual string Empresa { get; set; }
        #endregion
    }
}
