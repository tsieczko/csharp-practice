using System;
using static PrimeFactorsLib.PrimeFactorsLib;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(PrimeFactors(1000));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Argument out of acceptable range. Enter a number between 2 and 1000.");
            }
        }
    }
}
