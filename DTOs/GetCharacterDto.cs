
namespace DTOs
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string CharacterName { get; set; } = null!;
        public string CharacterSurname { get; set; } = null!;
        public int CharacterAge { get; set; }
    }
}