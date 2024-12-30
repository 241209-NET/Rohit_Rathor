using PokemonTracker.API.Model;

namespace PokemonTracker.API.Repository;

public interface IPokemonRepository
{
    Pkmn CreateNewPkmn(Pkmn pkmn);
}