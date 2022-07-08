using AutoMapper;
using CatologoProdAPI.DTO;
using CatologoProdAPI.Models;
using CatologoProdAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatologoProdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProductsController(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetProdutos(string? cat, string? sub)
        {
            var produtos = await _repository.GetProdutos(cat, sub);

            if(produtos == null)
            {
                return NotFound(new { error = "Produtos não encontrados" });
            }
            else
            {
                return Ok(produtos);
            }
        }

        [HttpPost("")]
        //
        public async Task<ActionResult> CadastrarProduto([FromForm] ProdutoDTO produto)
        {
            if (produto == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            ProdutoModel produtoModel = _mapper.Map<ProdutoDTO, ProdutoModel>(produto);

            await _repository.CadastrarProduto(produtoModel, produto.File1, produto.File2, produto.File3);
            return Ok();
            //return Created("", produto);
        }

        [HttpGet("{idProd}")]
        public async Task<ActionResult> GetProdutoById(string idProd)
        {
            var produto = await _repository.GetProdutoById(idProd);

            return Ok(produto);
        }


    }
}
