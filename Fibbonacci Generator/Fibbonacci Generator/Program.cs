using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool intParse = true;
            int amount = 0;
            while (intParse == true)
            {
                Console.WriteLine("Please enter the amount of fibonacci numbers to generate.");
                if (int.TryParse(Console.ReadLine(), out amount) == true)
                {
                    intParse = false;
                }
                else
                {
                    Console.WriteLine("There was an error with the input please try again.");
                    Console.Clear();
                }
            }

            UInt64 a = 0;
            UInt64 b = 1;
            UInt64 fibbiOutput = 0;
            Console.Write(a + ", ");

            for (int i = 0; i < amount -1; i++)
            {
                fibbiOutput = a + b;
                Console.Write(fibbiOutput + ", ");
                a = b;
                b = fibbiOutput;
            }
            Console.ReadLine();

        }
    }
}
