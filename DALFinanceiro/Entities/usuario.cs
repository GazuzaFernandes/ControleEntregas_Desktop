using System;
using System.Collections.Generic;
using System.Text;

namespace DALFinanceiro.Entities
{
   public class Usuario
    {        public virtual int UsuarioId { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual DateTime DataAlteracao { get; set; }
    }
}
