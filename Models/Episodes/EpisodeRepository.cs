
using RickNMortyDotnetApi.Models.Episodes;

namespace RickNMortyDotnetApi.Models.Episodes;

public class EpisodeRepository : IEpisodeRepository
{
    private static readonly List<Episode> Episodes = new();


    public List<Episode> GetAllEpisodes()
    {
        return Episodes;
    }

    public Episode GetEpisodeById(int id)
    {
        var episode = Episodes.FirstOrDefault(c => c.Id == id);
        if (episode is not null)
            return episode;

        throw new Exception($"Episode with ID {id} not found");

    }
}