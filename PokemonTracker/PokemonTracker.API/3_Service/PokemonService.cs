namespace PokemonTracker.API.Service;

using System.Collections.Generic;
using PokemonTracker.API.Model;
using PokemonTracker.API.Repository;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonService(IPokemonRepository pokemonRepository) => _pokemonRepository = pokemonRepository;

    public Pokemon CreateNewPokemon(Pokemon newPokemon)
    {
        throw new NotImplementedException();
    }

    public Pokemon? DeletePokemonById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pokemon> GetAllPokemon()
    {
        throw new NotImplementedException();
    }

    public Pokemon? GetPokemonById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pokemon> GetPokemonBySpecies(string name)
    {
        throw new NotImplementedException();
    }
}