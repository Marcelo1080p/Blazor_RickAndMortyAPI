namespace Blazor_RickAndMorty.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Image { get; set; }
        // Adicione outras propriedades conforme necessário
    }

    public class CharacterResponse
    {
        public List<Character> Results { get; set; }
    }
}
