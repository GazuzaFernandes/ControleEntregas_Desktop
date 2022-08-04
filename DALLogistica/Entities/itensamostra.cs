namespace DALLogistica.Entities
{
    public class itensamostra
    {
        #region  Pasta - Sistema Amostra - Form Amostra
        public virtual int itensamostraid { get; set; }
        public virtual int codigo { get; set; }
        public virtual string material { get; set; }
        public virtual decimal quantidade { get; set; }
        public virtual string observacao { get; set; }
        public virtual int amostraid { get; set; }
        #endregion
    }
}
