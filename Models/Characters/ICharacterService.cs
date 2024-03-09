using DTOs;


namespace RickNMortyDotnetApi.Models.Characters;

public interface ICharacterService
{
    ResponseService<List<GetCharacterDto>> GetAllCharacters(int pageNumber = 1, int pageSize = 1000);
    ResponseService<List<GetCharacterDto>> GetCharacterById(List<int> id);
}