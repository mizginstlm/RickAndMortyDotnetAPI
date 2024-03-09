using AutoMapper;
using DTOs;
using RickNMortyDotnetApi.DTOs;
using RickNMortyDotnetApi.Models.Characters;
namespace RickNMortyDotnetApi.Models.Episodes;

public class EpisodeService : IEpisodeService
{
    private readonly IEpisodeRepository _episodeRepository;
    private readonly IMapper _mapper;

    public EpisodeService(IMapper mapper, IEpisodeRepository episodeRepository)
    {
        _mapper = mapper;
        _episodeRepository = episodeRepository;
    }


    public ResponseService<List<GetEpisodeDto>> GetAllEpisodes()
    {
        var responseService = new ResponseService<List<GetEpisodeDto>>();
        List<Episode> Episodes = _episodeRepository.GetAllEpisodes();
        responseService.Data = _mapper.Map<List<GetEpisodeDto>>(Episodes);
        return responseService;
    }

    public ResponseService<GetEpisodeDto> GetEpisodeById(int id)
    {
        var responseService = new ResponseService<GetEpisodeDto>();
        var character = _episodeRepository.GetEpisodeById(id);
        responseService.Data = _mapper.Map<GetEpisodeDto>(character);
        return responseService;
    }

    public ResponseService<List<GetCharacterDto>> GetAllCharactersInEpisodes(int id)
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = _episodeRepository.GetAllCharactersInEpisodes(id);
        responseService.Data = _mapper.Map<List<GetCharacterDto>>(Characters);
        return responseService;
    }

}