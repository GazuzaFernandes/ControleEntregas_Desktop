using System;


namespace DALLogistica.Entities
{
   public class Amostra
    {
        #region Pasta Sistema Amostra - Form Amostra
        public virtual int AmostraId { get; set; }
        public virtual string Construtora { get; set; }
        public virtual DateTime DataEntrega { get; set; }
        public virtual string Obra { get; set; }
        public virtual string Material { get; set; }
        public virtual int StatusobraId { get; set; }
        #endregion
    }
}
