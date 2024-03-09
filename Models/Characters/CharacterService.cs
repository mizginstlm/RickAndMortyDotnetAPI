using AutoMapper;
using DTOs;
namespace RickNMortyDotnetApi.Models.Characters;

public class CharacterService : ICharacterService
{
    private readonly ICharacterRepository _characterRepository;
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper, ICharacterRepository characterRepository)
    {
        _mapper = mapper;
        _characterRepository = characterRepository;
    }


    public ResponseService<List<GetCharacterDto>> GetAllCharacters()
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = _characterRepository.GetAllCharacters();
        responseService.Data = _mapper.Map<List<GetCharacterDto>>(Characters);
        return responseService;
    }

    public ResponseService<GetCharacterDto> GetCharacterById(int id)
    {
        var responseService = new ResponseService<GetCharacterDto>();
        var character = _characterRepository.GetCharacterById(id);
        responseService.Data = _mapper.Map<GetCharacterDto>(character);
        return responseService;
    }

}