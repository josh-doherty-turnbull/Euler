using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem27 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"Euler discovered the remarkable quadratic formula:

n² + n + 41

It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39. However, when n = 40, 402 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, and certainly when n = 41, 41² + 41 + 41 is clearly divisible by 41.

The incredible formula  n² − 79n + 1601 was discovered, which produces 80 primes for the consecutive values n = 0 to 79. The product of the coefficients, −79 and 1601, is −126479.

Considering quadratics of the form:

n² + an + b, where |a| < 1000 and |b| < 1000

where |n| is the modulus/absolute value of n
e.g. |11| = 11 and |−4| = 4
Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Quadratic primes";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 27;
            }
        }

        protected override string Solve()
        {
            int highestPrimeCount = 0;
            int resultA = 0;
            int resultB = 0;

            for (int a = -1000; a < 1000; a++)
            {
                for (int b = -1000; b < 1000; b++)
                {
                    int primeCount = 0;

                    for (int n = 0; true; n++)
                    {
                        int temp = n * n + a * n + b;
                        
                        if (PrimeHelper.IsPrime(temp))
                        {
                            primeCount++;
                            if (primeCount > highestPrimeCount)
                            {
                                highestPrimeCount = primeCount;
                                resultA = a;
                                resultB = b;
                            }
                        }
                        else
                        {
                            break;
                        } 
                    }
                }
            }

            return (resultA * resultB).ToString("0");
        }
    }
}
