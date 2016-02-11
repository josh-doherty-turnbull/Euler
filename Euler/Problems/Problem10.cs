using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler.Helpers;

namespace Euler.Problems
{
    class Problem10 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Summation of primes";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 10;
            }
        }

        protected override string Solve()
        {
            long result = 0;

            IEnumerable<long> primes = PrimeHelper.GeneratePrimes(1999999);

            result = primes.Sum();

            return result.ToString("0");
        }
    }
}
