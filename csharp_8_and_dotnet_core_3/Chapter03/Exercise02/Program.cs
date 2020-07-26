using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                checked
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("There was an overflow");
            }
            
        }
    }
}
