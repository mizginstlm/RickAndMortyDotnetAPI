
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
    public ActionResult<Episode> GetSingle(int id)
    {
        return Ok(_episodeService.GetEpisodeById(id));
    }

    [HttpGet("{id}/characters")]
    public ActionResult<Episode> GetAllCharactersInEpisodes(int id)
    {
        return Ok(_episodeService.GetAllCharactersInEpisodes(id));
    }



}