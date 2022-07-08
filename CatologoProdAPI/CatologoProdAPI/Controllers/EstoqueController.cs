using AutoMapper;
using CatologoProdAPI.DTO;
using CatologoProdAPI.Models;
using CatologoProdAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatologoProdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : Controller
    {
        private readonly IEstoqueRepository _repository;
        private readonly IMapper _mapper;

        public EstoqueController(IEstoqueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetProdutosEstoque()
        {
            var produtos = await _repository.GetProdutosEstoque();

            if (produtos == null)
            {
                return NotFound(new { error = "Produtos não encontrados" });
            }
            else
            {
                return Ok(produtos);
            }
        }

        [HttpPut("")]
        public async Task<ActionResult> AlterarQuantidade([FromBody] ProdutoDTO produto)
        {
            ProdutoModel produtoModel = _mapper.Map<ProdutoDTO, ProdutoModel>(produto);

            if (produto != null)
            {
                await _repository.AlterarQuantidade(produtoModel);
            }

            return Ok();
        }


        [HttpDelete("{idProd}")]
        public async Task<ActionResult> DeleteProduto(string idProd)
        {
            if (idProd != "")
            {
                await _repository.DeleteProduto(idProd);
            }

            return Ok();
        }
    }
}
