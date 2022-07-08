using CatologoProdAPI.Models;

namespace CatologoProdAPI.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Task<List<ProdutoModel>> GetProdutos(string categoria, string subCategoria);
        Task<ProdutoModel> GetProdutoById(string idProd);
        Task CadastrarProduto(ProdutoModel produto, IFormFile Imagem1, IFormFile Imagem2, IFormFile Imagem3);
        Task AtualizarProduto(ProdutoModel produto);
        Task DeleteProduto(string idProd);
    }
}
