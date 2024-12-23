namespace PokemonTracker.API.Model;

public class Trainer
{
    public int Id { get; set;}
    public string Name { get; set;} = "";

    public List<Pokemon> Team { get; set; }
}
