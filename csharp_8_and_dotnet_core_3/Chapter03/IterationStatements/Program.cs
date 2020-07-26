using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = null;

            int passwordAttempts = 0;
            do
            {
                Write("Enter your password: ");
                // password = ReadLine();
                password = "Pa$$w0rd";
                passwordAttempts++;
                if (passwordAttempts >= 10)
                {
                    WriteLine("Too many wrong attempts!");
                    return;
                }
            } while (password != "Pa$$w0rd");

            WriteLine("Correct!");

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            string[] names = {"Adam", "Barry", "Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters");
            }
        }
    }
}
