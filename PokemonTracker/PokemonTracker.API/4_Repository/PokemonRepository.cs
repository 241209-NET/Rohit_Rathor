using PokemonTracker.API.Data;
using PokemonTracker.API.Model;

namespace PokemonTracker.API.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonContext _pokemonContext;
    
    public PokemonRepository(PokemonContext pokemonContext)
    {
        _pokemonContext = pokemonContext;
    }

    public Pkmn CreateNewPkmn(Pkmn newPkmn)
    {
        _pokemonContext.Pokemon.Add(newPkmn);
        _pokemonContext.SaveChanges();
        return newPkmn;
    }
}