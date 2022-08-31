

namespace DALOrcamento.Entities
{
    public class Produtos
    {
        public virtual int ProdutoId { get; set; }
        public virtual string Fornecedor { get; set; }
        public virtual string Produto { get; set; }
        public virtual string Preco { get; set; }
        public virtual string Rendimento { get; set; }
        public virtual string Comentario { get; set; }
    }
}
