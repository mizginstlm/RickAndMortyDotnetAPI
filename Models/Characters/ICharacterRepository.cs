namespace RickNMortyDotnetApi.Models.Characters;

public interface ICharacterRepository
{
    List<Character> GetAllCharacters();
    List<Character> GetCharacterById(List<int> id);

}