
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


    public Character GetCharacterById(int id)
    {
        var character = _context.Characters.FirstOrDefault(c => c.Id == id);
        return character;

        throw new Exception($"Character with ID {id} not found");

    }
}