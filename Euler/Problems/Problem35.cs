using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler.Helpers;

namespace Euler.Problems
{
    class Problem35 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.

There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.

How many circular primes are there below one million?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Circular primes";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 35;
            }
        }

        protected override string Solve()
        {
            int result = 0;

            IEnumerable<long> primes = PrimeHelper.GeneratePrimes(999999);

            foreach (long prime in primes)
            {
                IEnumerable<long> rotations = NumberHelper.GetRotations(prime);

                int primeCount = 0;

                foreach (long rotation in rotations)
                {
                    if (PrimeHelper.IsPrime(rotation)) primeCount++;
                }

                if (primeCount == rotations.Count()) result++;
            }

            return result.ToString("0");
        }
    }
}
