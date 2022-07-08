using CatologoProdAPI.DTO;
using CatologoProdAPI.Models;

namespace CatologoProdAPI.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        Task<List<PedidoDTO>> GetPedidos();
        Task<PedidoModel> GetPedidoById(string idPedido);
        Task IncluirPedido(PedidoModel pedido);
        Task DeletePedido(string idPedido);
        Task AlterarStatusPedido(PedidoDTO pedido);
        Task AlterarStatusPagamento(PedidoDTO pedido);
    }
}
