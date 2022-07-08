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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public PedidoController(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetPedidos()
        {
            var pedidos  = await _repository.GetPedidos();

            if (pedidos == null)
            {
                return NotFound(new { error = "Produtos não encontrados" });
            }
            else
            {
                return Ok(pedidos);
            }
        }

        [HttpGet("{idPedido}")]
        public async Task<ActionResult> GetPedidosById(string idPedido)
        {
            var pedido = await _repository.GetPedidoById(idPedido);

            if(pedido == null)
            {
                return NotFound(new { error = "Pedido não encontrado" });
            }
            else
            {
                return Ok(pedido);
            }
        }

        [HttpPost("")]
        public async Task<ActionResult> IncluirPedido([FromBody]PedidoDTO pedido)
        {
            var teste = 0;
            PedidoModel pedidoModel = _mapper.Map<PedidoDTO, PedidoModel>(pedido);

            await _repository.IncluirPedido(pedidoModel);

            return Ok();
        }

        [HttpDelete("{idPedido}")]
        public async Task<ActionResult> DeletePedido(string idPedido)
        {
            await _repository.DeletePedido(idPedido);

            return Ok();
        }

        [HttpPut("UpdateStatusPedido")]
        public async Task<ActionResult> AlterarStatusPedido([FromBody] PedidoDTO pedido)
        {
            await _repository.AlterarStatusPedido(pedido);

            return Ok();
        }

        [HttpPut("UpdateStatusPagamento")]
        public async Task<ActionResult> AlterarStatusPagamento([FromBody] PedidoDTO pedido)
        {
            await _repository.AlterarStatusPagamento(pedido);

            return Ok();
        }
    }
}
