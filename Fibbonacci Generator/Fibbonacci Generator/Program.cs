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


            UInt64[] fibbiArray = new UInt64[amount];
            fibbiArray[0] = 0;
            fibbiArray[1] = 1;

            for (int i = 2; i < amount; i++)
            {
                fibbiArray[i] = fibbiArray[i - 2] + fibbiArray[i - 1];
            }
            for (int i = 0; i < fibbiArray.Length; i++)
            {
                Console.Write(fibbiArray[i].ToString() + ", ");
            }
            Console.ReadLine();

        }
    }
}
