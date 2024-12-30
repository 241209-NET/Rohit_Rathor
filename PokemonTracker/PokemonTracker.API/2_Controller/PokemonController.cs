namespace PokemonTracker.API.Controller;

using Microsoft.AspNetCore.Mvc;
using PokemonTracker.API.Model;
using PokemonTracker.API.Service;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
    private readonly IPokemonService _pokemonService;

    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    [HttpPost]
    public IActionResult CreateNewPkmn(Pokemon newPkmn)
    {
        var pkmn = _pokemonService.CreateNewPokemon(newPkmn);
        return Ok(pkmn);
    }

}