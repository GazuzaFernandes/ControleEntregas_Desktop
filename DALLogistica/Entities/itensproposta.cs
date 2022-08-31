
namespace DALLogistica.Entities
{
    public class ItensProposta
    {
        #region  Pasta - Sistema Logistica - Form Proposta - Form Cadastro d Itens
        public virtual int ItenId { get; set; }
        public virtual string Material { get; set; }      
        public virtual string UndMedida { get; set; }
        public virtual decimal M2caixa { get; set; }
        public virtual decimal Quantidade { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual string M2NotaFiscal { get; set; }
        public virtual string ObsMaterial { get; set; }
        public virtual decimal Total { get; set; }
        public virtual int PropostaId { get; set; }
        public virtual int CodigoMaterial { get; set; }
        #endregion
    }
}
