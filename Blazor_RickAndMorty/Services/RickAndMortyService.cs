using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor_RickAndMorty.Models;

namespace Blazor_RickAndMorty.Services
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private readonly HttpClient httpClient;

        public RickAndMortyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Character>> GetCharacters()
        {
            var jsonString = await httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");

            var response = JsonSerializer.Deserialize<CharacterResponse>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return response?.Results ?? new List<Character>();
        }
    }
}
