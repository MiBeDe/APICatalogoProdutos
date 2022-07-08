using CatologoProdAPI.Models;

namespace CatologoProdAPI.Repositories.Interfaces
{
    public interface IEstoqueRepository
    {
        Task<List<ProdutoModel>> GetProdutosEstoque();
        Task AlterarQuantidade(ProdutoModel produto);
        Task DeleteProduto(string idProduto);
    }
}
