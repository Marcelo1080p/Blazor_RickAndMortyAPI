using Blazor_RickAndMorty.Models; 

namespace Blazor_RickAndMorty.Services
{
    public interface IRickAndMortyService
    {
        Task<List<Character>> GetCharacters();
    }
}
