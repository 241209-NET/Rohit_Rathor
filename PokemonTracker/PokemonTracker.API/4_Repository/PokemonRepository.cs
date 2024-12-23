using PokemonTracker.API.Data;

namespace PokemonTracker.API.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonContext _pokemonContext;
    
    public PokemonRepository(PokemonContext pokemonContext)
    {
        _pokemonContext = pokemonContext;
    }
}