using DTOs;


namespace RickNMortyDotnetApi.Models.Characters;

public interface ICharacterService
{
    ResponseService<List<GetCharacterDto>> GetAllCharacters();
    ResponseService<GetCharacterDto> GetCharacterById(int id);
}