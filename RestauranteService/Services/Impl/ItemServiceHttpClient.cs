using RestauranteService.Dtos;
using System.Text;
using System.Text.Json;

namespace RestauranteService.Services
{
    public class ItemServiceHttpClient : IItemServiceHttpClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public ItemServiceHttpClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async void EnviaRestaurante(RestauranteReadDto restauranteReadDto)
        {
            var conteudo = new StringContent(JsonSerializer.Serialize(restauranteReadDto), Encoding.UTF8, "application/json");

            await _client.PostAsync(_configuration["ItemService"],conteudo);
        }
    }
}
