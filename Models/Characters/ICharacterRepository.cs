namespace RickNMortyDotnetApi.Models.Characters;

public interface ICharacterRepository
{
    List<Character> GetAllCharacters();
    Character GetCharacterById(int id);

}