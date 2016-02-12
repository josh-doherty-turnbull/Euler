using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem37 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.

Find the sum of the only eleven primes that are both truncatable from left to right and right to left.

NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Truncatable primes";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 37;
            }
        }

        protected override string Solve()
        {
            int hitCount = 0;
            int result = 0;

            IList<long> primes = PrimeHelper.GeneratePrimes(100000000).ToList();

            primes.Remove(2);
            primes.Remove(3);
            primes.Remove(5);
            primes.Remove(7);

            for (int i = 0; i < primes.Count; i++)
            {
                bool primeCheck = true;

                int n = i;

                //check primality right to left
                do
                {
                    if (PrimeHelper.IsPrime(n) == false)
                    {
                        primeCheck = false;
                        break;
                    }
                    n /= 10;
                } while (n > 0);

                //check primality left to right
                if (primeCheck) //don't bother if already failed right to left
                {
                    n = i;
                    int modulo = (int)Math.Pow(10, (NumberHelper.GetDigits(n).Count() - 1));
                    do
                    {
                        n %= modulo;

                        modulo = (int)Math.Pow(10, (NumberHelper.GetDigits(n).Count() - 1));

                        if (PrimeHelper.IsPrime(n) == false)
                        {
                            primeCheck = false;
                            break;
                        }
                    } while (modulo != 1); 
                }

                
                if (primeCheck)
                {
                    result += i;
                    hitCount++;
                }
                if (hitCount == 11) return result.ToString("0");
            }

            return "none found";
        }
    }
}
