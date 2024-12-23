using PokemonTracker.API.Model;

namespace PokemonTracker.API.Service;

public interface IPokemonService
{
    Pokemon CreateNewPokemon(Pokemon newPokemon);
    Pokemon? GetPokemonById(int id);
    IEnumerable<Pokemon> GetPokemonBySpecies(string name);
    IEnumerable<Pokemon> GetAllPokemon();
    Pokemon? DeletePokemonById(int id);
}