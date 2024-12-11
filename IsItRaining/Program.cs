using System.ComponentModel.Design;

namespace IsItRaining;

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    public static void MainMenu()
    {
        Console.WriteLine("1. Check the Weather");
        Console.WriteLine("2. Check Date");
        Console.WriteLine("3. Exit");

        int choice = 0;

        try
        {
            Console.WriteLine("Please Enter A Number: ");
            string input = Console.ReadLine()!;
            choice = int.Parse(input);
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Choice!");
        }

        switch (choice)
        {
            case 1:
                CheckWeather();
                break;
            case 2:
                CheckDate();
                break;
            case 3:
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            default:
                break;
        }
        
    }

    private static void CheckDate()
    {
        Console.WriteLine("The Current Date is: " + DateOnly.FromDateTime(DateTime.Now));
        MainMenu();
    }

    private static void CheckWeather()
    {
        List<string> locations = [];

        string input = "";
        while (!input.Equals("!"))
        {
            
            Console.WriteLine("Enter a Location or '!' to continue: ");

            input = Console.ReadLine();

            if (input is not null)
            {
                if (input.Equals("!"))
                {
                    break;
                }
                locations.Add(input);
            }
        }

        Console.WriteLine("Checking Current Weather...");

        foreach (string l in locations)
        {
            Random rnd = new();
            bool raining = rnd.NextDouble() >= 0.5;

            if (raining)
            {
                Console.WriteLine($"It is currently raining in {l}. Have Fun!");
            }
            else
            {
                Console.WriteLine($"It will never rain again in {l}! Good Luck!");
            }
        }

        MainMenu();
        
    }
}
