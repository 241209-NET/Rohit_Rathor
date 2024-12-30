using PokemonTracker.API.Model;

namespace PokemonTracker.API.Service;

public interface IPokemonService
{
    Pkmn CreateNewPokemon(Pkmn newPokemon);
    Pkmn? GetPokemonById(int id);
    IEnumerable<Pkmn> GetPokemonBySpecies(string name);
    IEnumerable<Pkmn> GetAllPokemon();
    Pkmn? DeletePokemonById(int id);
}