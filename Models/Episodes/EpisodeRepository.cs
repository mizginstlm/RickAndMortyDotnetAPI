
using RickNMortyDotnetApi.Data;
using RickNMortyDotnetApi.Models.Characters;
using RickNMortyDotnetApi.Models.Episodes;

namespace RickNMortyDotnetApi.Models.Episodes;

public class EpisodeRepository : IEpisodeRepository
{
    private readonly AppDbContext _context;
    public EpisodeRepository(AppDbContext context)
    {
        _context = context;
    }


    public List<Episode> GetAllEpisodes()
    {
        var Episodes = _context.Episode.ToList();
        return Episodes;
    }

    public List<Episode> GetEpisodeById(List<int> id)
    {
        var episodes = _context.Episode
                .Where(e => id.Contains(e.Id))
                .ToList();
        return episodes;

        throw new Exception($"Episode with ID {id} not found");

    }


    public List<Character> GetAllCharactersInEpisodes(int id)
    {
        var episode = _context.Episode.FirstOrDefault(e => e.Id == id);
        if (episode is not null)
        {
            var characters = _context.Characters.Where(c => c.Episode.Contains(episode)).ToList();
            return characters;
        }
        throw new Exception($"Episode with ID {id} not found");
    }
}