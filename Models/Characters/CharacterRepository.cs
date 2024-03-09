
using RickNMortyDotnetApi.Data;
using RickNMortyDotnetApi.Models.Characters;

namespace RickNMortyDotnetApi.Models.Characters;

public class CharacterRepository(AppDbContext context) : ICharacterRepository
{
    private readonly AppDbContext _context = context;
    public List<Character> GetAllCharacters()
    {
        var Characters = _context.Characters.ToList();
        return Characters;
    }

    public List<Character> GetCharacterById(List<int> id)
    {

        var characters = _context.Characters
                .Where(e => id.Contains(e.Id))
                .ToList();
        return characters;

        throw new Exception($"Character with ID {id} not found");

    }
}