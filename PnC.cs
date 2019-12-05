using System.Numerics; 

namespace DiscreteProject
{
    internal class PnC : Stirling
    {
        public static BigInteger nCr(BigInteger n, BigInteger r)
        {
            return nPr(n, r) / Factorial(r);
        }

        public static BigInteger nPr(BigInteger n, BigInteger r)
        {
            return FactorialDivision(n, n - r);
        }
        public static BigInteger nPrWR(BigInteger n, BigInteger r)
        {
            return PowerCalculator(n, r);
        }
        public static BigInteger nCrWR(BigInteger n, BigInteger r)
        {
            return nCr(n + r - 1, r);
        }

        private static BigInteger FactorialDivision(BigInteger topFactorial, BigInteger divisorFactorial)
        {
            BigInteger result = 1;
            for (BigInteger i = topFactorial; i > divisorFactorial; i--)
            {
                result *= i;
            }
            return result;
        }

        public static BigInteger Factorial(BigInteger i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }

        public static BigInteger PowerCalculator(BigInteger number, BigInteger exponent)
        {
            BigInteger result = number;
            if (exponent <= 0)
            {
                result = (number - (number + 1)) * -1;
            }
            else
            {
                for (BigInteger j = exponent; j > 1; j--)
                {
                    result = result * number;
                }
            }
            return result;
        }
    }
}