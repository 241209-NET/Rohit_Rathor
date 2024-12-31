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
        _pokemonContext.Pkmns.Add(newPkmn);
        _pokemonContext.SaveChanges();
        return newPkmn;
    }

    public void DeletePkmnByName(string name)
    {
        var pkmn = GetPkmnByName(name).First();
        _pokemonContext.Pkmns.Remove(pkmn!);
        _pokemonContext.SaveChanges();
    }

    public IEnumerable<Pkmn> GetAllPkmn()
    {
        return _pokemonContext.Pkmns.ToList();
    }

    public IEnumerable<Pkmn> GetAllPkmnBySpecies(string species)
    {
        var pkmn = _pokemonContext.Pkmns.Where(p => p.Species.Equals(species)).ToList();

        return pkmn;
    }

    public IEnumerable<Pkmn> GetAllPkmnByType(string type)
    {
        var pkmn = _pokemonContext.Pkmns.Where(p => p.Type.Contains(type)).ToList();

        return pkmn;
    }

    public IEnumerable<Pkmn> GetPkmnByName(string name)
    {
        var pkmn = _pokemonContext.Pkmns.Where(p => p.Name.Equals(name)).ToList();

        return pkmn;
    }
}