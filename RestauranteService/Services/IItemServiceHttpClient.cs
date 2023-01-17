using RestauranteService.Dtos;

namespace RestauranteService.Services
{
    public interface IItemServiceHttpClient
    {
        public void EnviaRestaurante(RestauranteReadDto restauranteReadDto);
    }
}
