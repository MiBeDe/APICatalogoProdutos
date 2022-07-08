namespace CatologoProdAPI.DTO
{
    public class ProdutoDTO
    {
        public string? IdProd { get; set; }
        public string? Categoria { get; set; }
        public string? SubCategoria { get; set; }
        public string? NomeProduto { get; set; }
        public string? Descricao { get; set; }
        public string? Tamanho { get; set; }
        public string? Cor { get; set; }
        public double? Preco { get; set; }
        public int? Quantidade { get; set; }
        public string? PathImages { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }

        public IFormFile? File1 { get; set; }
        public IFormFile? File2 { get; set; }
        public IFormFile? File3 { get; set; }

        public ChecksTamanhosDTO? checksTamanhos { get; set; }
        public PedidoDTO? pedido { get; set; }
    }
}
