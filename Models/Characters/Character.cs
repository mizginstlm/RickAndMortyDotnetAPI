using RickNMortyDotnetApi.Models.Episodes;

namespace RickNMortyDotnetApi.Models.Characters;

public class Character
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = null!;
    public string CharacterSurname { get; set; } = null!;
    public int CharacterAge { get; set; }
    public string Role { get; set; } = null!;
    public List<Episode> Episodes { get; set; } = new();
}