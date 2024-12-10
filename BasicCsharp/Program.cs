using System;

namespace BasicCsharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        String input = Console.ReadLine() ?? "Hello"; // ! - Suppresses warnings, ? after variable type means value could be null

        /** Same as ?? above
        String input = Console.ReadLine();
        if (input == null) input = "Hello";
        */

        Console.WriteLine(input?.Trim()); // ? - if input is not null, run Trim method

        // Whole Numbers
        int one = 0; // 32-bit
        long two = 0L; // 64-bit
        short three = 0; // 16-bit
        byte four = 0; // unsigned 8-bit

        // Floating-Point Numbers
        double five = 0.0; // 64-bit
        float six = 0.0f; // 32-bit

        // Characters & Boolean
        char c = 'a'; // Single character
        bool isTrue = false; // True / False

        // String, not primitive but is built-in
        String s = "I'm not primitive!";


        // Arithmetic Operators
        int num = 1 + 1;
        num = 42 - 16;
        num = 4 * 86;
        num = 46 / 7;
        num = 97 % 2;

        // Comparison Operators
        bool checking = (2 == 3);
        checking = num != one;
        checking = num > one;
        checking = num < one;
        checking = num >= one;
        checking = num <= one;

        // Logical Operators
        bool check2 = checking && isTrue;
        check2 = checking || isTrue;
        check2 = !checking;

        // Look up Bitwise Operators

        // Assignment Operators
        int number = 6;
        number = 7;
        number += 3;
        number -= 2;
        number *= 1;
        number /= 5;

        // Operators Can Be Overridden


    }
}
