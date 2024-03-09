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

    public ResponseService<List<GetEpisodeDto>> GetEpisodeById(List<int> id)
    {
        var responseService = new ResponseService<List<GetEpisodeDto>>();
        List<Episode> Episodes = _episodeRepository.GetEpisodeById(id);
        responseService.Data = _mapper.Map<List<GetEpisodeDto>>(Episodes);
        return responseService;
    }

    public ResponseService<List<GetCharacterDto>> GetAllCharactersInEpisodes(int id, int pageNumber = 1, int pageSize = 1000)
    {
        var responseService = new ResponseService<List<GetCharacterDto>>();
        List<Character> Characters = _episodeRepository.GetAllCharactersInEpisodes(id);

        var skipResults = (pageNumber - 1) * pageSize;
        Characters = Characters.Skip(skipResults).Take(pageSize).ToList();
        responseService.Data = _mapper.Map<List<GetCharacterDto>>(Characters);
        return responseService;
    }

}