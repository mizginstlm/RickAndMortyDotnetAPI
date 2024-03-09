using AutoMapper;
using DTOs;
using RickNMortyDotnetApi.DTOs;
namespace RickNMortyDotnetApi.Models.Episodes;

public class EpisodeService : IEpisodeService
{
    private readonly IEpisodeRepository characterRepository;
    private readonly IMapper _mapper;

    public EpisodeService(IMapper mapper)
    {
        _mapper = mapper;
        characterRepository = new EpisodeRepository();
    }


    public ResponseService<List<GetEpisodeDto>> GetAllEpisodes()
    {
        var responseService = new ResponseService<List<GetEpisodeDto>>();
        List<Episode> Episodes = characterRepository.GetAllEpisodes();
        responseService.Data = _mapper.Map<List<GetEpisodeDto>>(Episodes);
        return responseService;
    }

    public ResponseService<GetEpisodeDto> GetEpisodeById(int id)
    {
        var responseService = new ResponseService<GetEpisodeDto>();
        var character = characterRepository.GetEpisodeById(id);
        responseService.Data = _mapper.Map<GetEpisodeDto>(character);
        return responseService;
    }

}