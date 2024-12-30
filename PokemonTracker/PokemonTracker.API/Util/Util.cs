using Newtonsoft.Json;
using PokeApiNet;
using PokemonTracker.API.Model;

namespace PokemonTracker.API.Util;

public static class Utilities
{
    private static readonly HttpClient pokeApi = new()
    {
        BaseAddress = new Uri("https://pokeapi.co/api/v2/")
    };

    public static Pkmn ConvertPokemonToPkmn(Pkmn newPkmn)
    {
        var actualPkmn = pokeApi.GetAsync($"pokemon/{newPkmn.Species.ToLower()}").Result;
        Pokemon pokemonJSON = JsonConvert.DeserializeObject<Pokemon>(actualPkmn.Content.ReadAsStringAsync().Result);

        newPkmn.Species = pokemonJSON!.Species.Name;

        foreach (PokemonType t in pokemonJSON.Types)
        {
            newPkmn.Type += t.Type.Name + "/";
        }

       /*  var pkmnSpeciesAPI = pokeApi.GetAsync($"https://pokeapi.co/api/v2/pokemon-species/ditto").Result;
        PokemonSpecies speciesJSON = JsonConvert.DeserializeObject<PokemonSpecies>(pkmnSpeciesAPI.Content.ReadAsStringAsync().Result);
        Console.WriteLine("TYPES" + speciesJSON.BaseHappiness); */

        return newPkmn;
    }
}