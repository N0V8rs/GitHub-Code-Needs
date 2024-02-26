using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_non_static
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int count = 0; // a number of 0 
            while (true)
            {
                Console.WriteLine(count);
                count++; // adds one to the count number
                Console.ReadKey(true);

                if (count == -50)
                {
                    Console.WriteLine();
                    //Console.ReadKey(true); Doesn't work
                }
            }
        }
    }
}
