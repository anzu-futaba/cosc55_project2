using System.Numerics;
using System;

namespace DiscreteProject
{
    internal class Stirling
    {
        public static BigInteger Stirling_method(BigInteger n, BigInteger k)
        {
            return Stirling_Calculate(n, k);
        }
        private static BigInteger Stirling_Calculate(BigInteger n, BigInteger k)
        {
            //(-1)^i(kCi)(k-i)^n = sum/k!
            BigInteger constant = -1;
            BigInteger i;
            BigInteger sum = 0;
            for(i = 0; i < k; i++)
            {
                //Console.WriteLine(PnC.PowerCalculator(constant, i) * PnC.nCr(k, i) * PnC.PowerCalculator(k-i, n));
                sum = sum + (PnC.PowerCalculator(constant, i) * PnC.nCr(k, i) * PnC.PowerCalculator(k - i, n));
            }
            //sum/k factorial
            return sum / PnC.Factorial(k);
            
        }
    }
}