using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Enter a number between 0 and 255: ");
                byte number1 = byte.Parse(ReadLine());
                Write("Enter another number between 0 and 255: ");
                byte number2 = byte.Parse(ReadLine());
                WriteLine($"{number1} divided by {number2} is {number1/number2}");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }
            WriteLine($"{7 | 8}");
        }
    }
}
