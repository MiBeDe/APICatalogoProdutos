using System.ComponentModel.DataAnnotations;

namespace CatologoProdAPI.DTO
{
    public class PedidoDTO
    {
        public string? IdPedido { get; set; }
        public string? Vendedor { get; set; }
        public string? Cliente { get; set; }
        public string? IdProduto { get; set; }
        public string? Produto { get; set; }
        public string? Tamanho { get; set; }
        public string? Cor { get; set; }
        public double? Preco { get; set; }
        public string? Categoria { get; set; }
        public string? SubCategoria { get; set; }
        public int? Quantidade { get; set; }
        public string? DataPedido { get; set; }
        public string? DataEnvio { get; set; }
        public int? StatusPagamento { get; set; }
        public int? StatusPedido { get; set; }
        public string? Image { get; set; }
    }
}
