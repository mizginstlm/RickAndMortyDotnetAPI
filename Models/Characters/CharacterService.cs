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


    public ResponseService<List<GetCharacterDto>> GetAllCharacters(int pageNumber = 1, int pageSize = 1000)
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = _characterRepository.GetAllCharacters();

        var skipResults = (pageNumber - 1) * pageSize;

        var paginatedCharacters = Characters.Skip(skipResults).Take(pageSize).ToList();

        responseService.Data = _mapper.Map<List<GetCharacterDto>>(paginatedCharacters);
        return responseService;
    }

    public ResponseService<List<GetCharacterDto>> GetCharacterById(List<int> id)
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = _characterRepository.GetCharacterById(id);
        responseService.Data = _mapper.Map<List<GetCharacterDto>>(Characters);
        return responseService;
    }

}