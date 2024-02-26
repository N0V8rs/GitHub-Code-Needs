using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 9608; i++)
        {
            char character = (char)i;
            Console.WriteLine($"ASCII value: {i}, Character: {character}");
        }

        Console.WriteLine("ASCII loop is complete. Press any key to exit.");
        Console.ReadKey();
    }
}

