using AutoMapper;
using CatologoProdAPI.DTO;
using CatologoProdAPI.Models;

namespace CatologoProdAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ProdutoModel, ProdutoDTO>();
            CreateMap<ProdutoModel, ProdutoDTO>().ReverseMap();

            CreateMap<PedidoModel, PedidoDTO>();
            CreateMap<PedidoModel, PedidoDTO>().ReverseMap();
        }
    }
}
