using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] typeNames = {
                "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"
            };
            int[] typeBytes = {
                sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal)
            };
            object[] typeMin = {
                sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue
            };
            object[] typeMax = {
                sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue
            };


            string formatString = "{0,-8}{1,-5}{2,32}{3,32}";
            Console.WriteLine(
                formatString,
                "Type",
                "Bytes",
                "Min",
                "Max"
            );
            for (int i=0; i<typeNames.Length; i++)
            {
                Console.WriteLine(
                    formatString,
                    typeNames[i],
                    typeBytes[i],
                    typeMin[i],
                    typeMax[i]
                );
            }
        }
    }
}
