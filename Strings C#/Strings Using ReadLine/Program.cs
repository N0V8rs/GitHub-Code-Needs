using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_using_ReadLine
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name (Press Esc to exit):");

            while (true)
            {
                // Read a key from the console
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Check if the key pressed is the Escape key
                if (keyInfo.Key == ConsoleKey.Escape)
                    break;

                // If it's not the Escape key, continue reading the rest of the name
                string userName = keyInfo.KeyChar + Console.ReadLine();

                // Greet the user
                Console.WriteLine("Hello, " + userName + "! Nice to meet you.");
            }
        }
    }
}
