using RestauranteService.Dtos;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestauranteService.Services
{
    public class ItemServiceHttpClient : IItemServiceHttpClient
    {
        private readonly HttpClient _client;

        public ItemServiceHttpClient(HttpClient client)
        {
            _client = client;
        }

        public void EnviaRestaurante(RestauranteReadDto restauranteReadDto)
        {
            var conteudo = new StringContent(JsonSerializer.Serialize(restauranteReadDto), Encoding.UTF8, "application/json");

            throw new NotImplementedException();
        }
    }
}
