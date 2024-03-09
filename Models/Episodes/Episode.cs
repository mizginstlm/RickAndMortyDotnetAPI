
using RickNMortyDotnetApi.Models.Characters;

namespace RickNMortyDotnetApi.Models.Episodes
{
    public class Episode
    {

        public int Id { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public List<Character> Characters { get; set; } = new();
    }
}