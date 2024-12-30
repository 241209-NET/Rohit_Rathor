using PokemonTracker.API.Model;

namespace PokemonTracker.API.Repository;

public interface IPokemonRepository
{
    Pokemon CreateNewPkmn(Pokemon pkmn);
}