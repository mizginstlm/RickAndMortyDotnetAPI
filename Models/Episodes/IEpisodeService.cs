using DTOs;
using RickNMortyDotnetApi.DTOs;
namespace RickNMortyDotnetApi.Models.Episodes;

public interface IEpisodeService
{
    ResponseService<List<GetEpisodeDto>> GetAllEpisodes();
    ResponseService<List<GetEpisodeDto>> GetEpisodeById(List<int> id);

    ResponseService<List<GetCharacterDto>> GetAllCharactersInEpisodes(int id, int pageNumber = 1, int pageSize = 1000);
}