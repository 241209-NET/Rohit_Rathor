namespace PokemonTracker.API.Model;

public class Pokemon
{
    public int Id { get; set; }
    public string Species { get; set; } = "";
    public string Name { get; set; } = "";
    public string Type { get; set;} = "";
    public string PokedexDesc { get; set; } = "";
    public int TrainerID { get; set; }

}