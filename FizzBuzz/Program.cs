namespace FizzBuzz;

/** 
Given a number by the user
Count starting from 1 to n
Each time we get to a number that is divisible by 3, replace with Fizz
Each time we get to a number that is divisible by 5, replace with Buzz
Each time we get to a number that is divisible by 3 and 5 (ex. 15), replace with FizzBuzz
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            input = "1";
        }

        int num = Convert.ToInt32(input);

        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else Console.WriteLine(i);
        }
    }
}
