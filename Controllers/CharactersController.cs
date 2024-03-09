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
    public ActionResult<ResponseService<List<Character>>> Get()
    {
        return Ok(_characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(int id)
    {
        return Ok(_characterService.GetCharacterById(id));
    }

}