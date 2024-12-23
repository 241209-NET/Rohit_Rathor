namespace PokemonTracker.API.Controller;

using Microsoft.AspNetCore.Mvc;
using PokemonTracker.API.Model;
using PokemonTracker.API.Service;

public class PokemonController : ControllerBase
{
    private readonly IPokemonService _pokemonService;

    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }
}