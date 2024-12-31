using PokemonTracker.API.Model;

namespace PokemonTracker.API.Repository;

public interface IPokemonRepository
{
    Pkmn CreateNewPkmn(Pkmn pkmn);
    IEnumerable<Pkmn> GetAllPkmn();
    IEnumerable<Pkmn> GetAllPkmnByType(string type);
    IEnumerable<Pkmn> GetAllPkmnBySpecies(string species);
    IEnumerable<Pkmn> GetPkmnByName(string name);
    void DeletePkmnByName(string name);
}

public interface ITrainerRepository
{
    Trainer? CreateNewTrainer(Trainer trainer);
    IEnumerable<Trainer> GetAllTrainers();
    Trainer? GetTrainerByName(string name);
    IEnumerable<Trainer> GetTeam(string name);
    Trainer? DeleteTrainerByName(Trainer trainer);
}