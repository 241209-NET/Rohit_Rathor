using PokemonTracker.API.Model;

namespace PokemonTracker.API.Service;

public interface IPokemonService
{
    Pkmn? CreateNewPkmn(Pkmn pkmn);
    IEnumerable<Pkmn> GetAllPkmn();
    IEnumerable<Pkmn> GetAllPkmnByType(string type);
    IEnumerable<Pkmn> GetAllPkmnBySpecies(string species);
    IEnumerable<Pkmn> GetPkmnByName(string name);
    Pkmn? DeletePkmnByName(string name);
}