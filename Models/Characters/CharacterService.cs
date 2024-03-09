using AutoMapper;
using DTOs;
namespace RickNMortyDotnetApi.Models.Characters;

public class CharacterService : ICharacterService
{
    private readonly ICharacterRepository characterRepository;
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper)
    {
        _mapper = mapper;
        characterRepository = new CharacterRepository();
    }


    public ResponseService<List<GetCharacterDto>> GetAllCharacters()
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = characterRepository.GetAllCharacters();
        responseService.Data = _mapper.Map<List<GetCharacterDto>>(Characters);
        return responseService;
    }

    public ResponseService<GetCharacterDto> GetCharacterById(int id)
    {
        var responseService = new ResponseService<GetCharacterDto>();
        var character = characterRepository.GetCharacterById(id);
        responseService.Data = _mapper.Map<GetCharacterDto>(character);
        return responseService;
    }

}