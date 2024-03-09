using RickNMortyDotnetApi.Models.Characters;

namespace RickNMortyDotnetApi.Models.Episodes;

public interface IEpisodeRepository
{
    List<Character> GetAllCharactersInEpisodes(int id);
    List<Episode> GetAllEpisodes();
    List<Episode> GetEpisodeById(List<int> id);

}