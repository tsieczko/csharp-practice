using System;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactorsLib
    {
        static public string PrimeFactors(int number)
        {
            if (number > 1000 || number < 2) throw new ArgumentOutOfRangeException();

            string result = $"Prime factors of {number} are:";
            List<int> primeFactors = ComputePrimeFactors(new List<int>(), number);

            for (int i = 0; i < primeFactors.Count; i++)
            {
                if (i == 0)
                {
                    result = $"{result} {primeFactors[i]}";
                }
                else
                {
                    result = $"{result} x {primeFactors[i]}";
                }
            }

            return result;
        }

        static public List<int> ComputePrimeFactors(List<int> factors, int number)
        {
            for (int factor = number; factor > 1; factor--) 
            {
                if (IsFactor(factor, number) && IsPrime(factor))
                {
                    factors.Add(factor);
                    ComputePrimeFactors(factors, number / factor);
                    return factors;
                }
            }
            return factors;
        }

        static public bool IsPrime(int number)
        {
            int root = (int) Math.Sqrt(number);
            for (int i = 2; i <= root; i++)
            {
                if (number % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        static public bool IsFactor(int candidate, int number)
        {
            return (number % candidate) == 0;
        }
    }
}
