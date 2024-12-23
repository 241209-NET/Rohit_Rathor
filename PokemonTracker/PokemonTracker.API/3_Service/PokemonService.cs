namespace PokemonTracker.API.Service;

using PokemonTracker.API.Model;
using PokemonTracker.API.Repository;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonService(IPokemonRepository pokemonRepository) => _pokemonRepository = pokemonRepository;
}