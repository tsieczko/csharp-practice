using System;
using System.Collections.Generic;
using Xunit;
using static PrimeFactorsLib.PrimeFactorsLib;

namespace PrimeFactorsLibTest
{
    public class PrimeFactorsTest
    {
        [Theory]
        [InlineData(4, "Prime factors of 4 are: 2 x 2")]
        [InlineData(7, "Prime factors of 7 are: 7")]
        [InlineData(30, "Prime factors of 30 are: 5 x 3 x 2")]
        [InlineData(40, "Prime factors of 40 are: 5 x 2 x 2 x 2")]
        [InlineData(50, "Prime factors of 50 are: 5 x 5 x 2")]
        public void TestPrimeFactors(int number, string expected)
        {
            Assert.Equal(expected, PrimeFactors(number));
        }

        [Fact]
        public void TestPrimeFactorsOf1001()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrimeFactors(1001));
        }

        [Fact]
        public void TestPrimeFactorsOf1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrimeFactors(1));
        }

        [Fact]
        public void TestPrimeFactorsOf0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate() 
            {
                PrimeFactors(0);
            });
        }

        [Fact]
        public void TestPrimeFactorsOfNegative1()
        {
            Action testCode = delegate() {
                PrimeFactors(-1);
            };

            Assert.Throws<ArgumentOutOfRangeException>(testCode);
        }
    }

    public class ComputePrimeFactorsTest
    {
        [Theory]
        [InlineData(4, new int[] {2, 2})]
        [InlineData(7, new int[] {7})]
        [InlineData(30, new int[] {5, 3, 2})]
        [InlineData(40, new int[] {5, 2, 2, 2})]
        [InlineData(50, new int[] {5, 5, 2})]
        public void TestComputePrimeFactors(int number, int[] expected)
        {
            Assert.Equal(expected, ComputePrimeFactors(new List<int>(), number).ToArray());
        }
    }

    public class IsPrimeTest
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(17, true)]
        [InlineData(19, true)]
        [InlineData(23, true)]
        public void TestIsPrimePrimeNumbers(int number, bool expected)
        {
            Assert.Equal(expected, IsPrime(number));
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(12, false)]
        [InlineData(14, false)]
        [InlineData(15, false)]
        [InlineData(16, false)]
        [InlineData(18, false)]
        [InlineData(20, false)]
        [InlineData(21, false)]
        [InlineData(22, false)]
        [InlineData(24, false)]
        public void TestIsPrimeCompositeNumbers(int number, bool expected)
        {
            Assert.Equal(expected, IsPrime(number));
        }
    }

    public class IsFactorTest
    {
        [Theory]
        [InlineData(10, 10, true)]
        [InlineData(5, 10, true)]
        [InlineData(2, 10, true)]
        [InlineData(1, 10, true)]
        [InlineData(3, 10, false)]
        [InlineData(4, 10, false)]
        [InlineData(6, 10, false)]
        [InlineData(7, 10, false)]
        public void TestIsFactor(int candidate, int number, bool expected)
        {
            Assert.Equal(expected, IsFactor(candidate, number));
        }
    }
}
