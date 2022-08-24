
namespace DALLogistica.Entities
{
    public class ItensProposta
    {
        #region  Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public virtual int itenid { get; set; }
        public virtual string material { get; set; }      
        public virtual string undmedida { get; set; }
        public virtual decimal m2caixa { get; set; }
        public virtual decimal quantidade { get; set; }
        public virtual decimal preco { get; set; }
        public virtual string metragemcaixa { get; set; }
        public virtual string obsmaterial { get; set; }
        public virtual decimal total { get; set; }
        public virtual int propostaid { get; set; }
        public virtual int codigomaterial { get; set; }
        #endregion
    }
}
