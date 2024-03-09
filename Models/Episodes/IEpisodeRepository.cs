namespace RickNMortyDotnetApi.Models.Episodes;

public interface IEpisodeRepository
{
    List<Episode> GetAllEpisodes();
    Episode GetEpisodeById(int id);

}