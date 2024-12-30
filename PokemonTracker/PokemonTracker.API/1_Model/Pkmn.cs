using System.Text.Json.Serialization;

namespace PokemonTracker.API.Model;

public class Pkmn
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Species { get; set; } = "";
    public string Name { get; set; } = "";

    [JsonIgnore]
    public string Type { get; set;} = "";
    
    [JsonIgnore]
    public string PokedexDesc { get; set; } = "";
    public int TrainerID { get; set; }
}