
using RickNMortyDotnetApi.Models.Characters;

namespace RickNMortyDotnetApi.Models.Characters;

public class CharacterRepository : ICharacterRepository
{
    private static readonly List<Character> Characters = new();


    public List<Character> GetAllCharacters()
    {
        return Characters;
    }


    public Character GetCharacterById(int id)
    {
        var character = Characters.FirstOrDefault(c => c.Id == id);
        if (character is not null)
            return character;

        throw new Exception($"Character with ID {id} not found");

    }
}