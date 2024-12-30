namespace PokemonTracker.API.Service;

using System.Collections.Generic;
using PokemonTracker.API.Model;
using PokemonTracker.API.Repository;
using PokemonTracker.API.Util;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonService(IPokemonRepository pokemonRepository) => _pokemonRepository = pokemonRepository;

    public Pkmn CreateNewPokemon(Pkmn newPkmn)
    {
        Pkmn pkmn = Utilities.ConvertPokemonToPkmn(newPkmn);

        return _pokemonRepository.CreateNewPkmn(pkmn);
    }

    public Pkmn? DeletePokemonById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pkmn> GetAllPokemon()
    {
        throw new NotImplementedException();
    }

    public Pkmn? GetPokemonById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pkmn> GetPokemonBySpecies(string name)
    {
        throw new NotImplementedException();
    }
}