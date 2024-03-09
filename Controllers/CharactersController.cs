using Microsoft.AspNetCore.Mvc;
using RickNMortyDotnetApi.Models;
using RickNMortyDotnetApi.Models.Characters;

namespace RickNMortyDotnetApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly ICharacterService _characterService;
    public CharactersController(ICharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet]
    public ActionResult<ResponseService<List<Character>>> Get(int pageNumber = 1, int pageSize = 10)
    {
        return Ok(_characterService.GetAllCharacters(pageNumber, pageSize));
    }

    [HttpGet("{id}")]
    public ActionResult<List<Character>> GetSingle([FromQuery] List<int> id)
    {
        return Ok(_characterService.GetCharacterById(id));
    }
}