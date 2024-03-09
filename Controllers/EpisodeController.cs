
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RickNMortyDotnetApi.Models;
using RickNMortyDotnetApi.Models.Episodes;
namespace RickNMortyDotnetApi.Controllers;


[Route("api/[controller]")]
[ApiController]

public class EpisodeController
: ControllerBase
{

    private readonly IEpisodeService _episodeService;

    public EpisodeController(IEpisodeService episodeService)
    {
        _episodeService = episodeService;
    }

    [HttpGet]
    public ActionResult<ResponseService<List<Episode>>> Get()
    {
        return Ok(_episodeService.GetAllEpisodes());
    }

    [HttpGet("{id}")]
    public ActionResult<List<Episode>> GetSingle([FromQuery] List<int> id)
    {
        return Ok(_episodeService.GetEpisodeById(id));
    }

    [HttpGet("{id}/characters")]
    public ActionResult<Episode> GetAllCharactersInEpisodes(int id, int pageNumber = 1, int pageSize = 1000)
    {
        return Ok(_episodeService.GetAllCharactersInEpisodes(id, pageNumber, pageSize));
    }



}