using DTOs;
using RickNMortyDotnetApi.DTOs;
namespace RickNMortyDotnetApi.Models.Episodes;

public interface IEpisodeService
{
    ResponseService<List<GetEpisodeDto>> GetAllEpisodes();
    ResponseService<GetEpisodeDto> GetEpisodeById(int id);

    ResponseService<List<GetCharacterDto>> GetAllCharactersInEpisodes(int id);
}