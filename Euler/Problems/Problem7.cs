using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem7 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "10001st prime";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 7;
            }
        }

        protected override string Solve()
        {
            //stab in the dark here, the 10001st prime is probably below 10million?

            //could check numbers incrementally as prime or not, but a Sieve would be faster still

            IList<long> primes = PrimeHelper.GeneratePrimes(10000000).ToList();

            primes.OrderBy(o => o);

            return primes[10000].ToString("0");
        }
    }
}
