using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem3 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Largest prime factor";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 3;
            }
        }

        protected override string Solve()
        {
            IEnumerable<long> primeFactors = PrimeHelper.Factorise(600851475143, true);

            return primeFactors.Max().ToString("0");                
        }
    }
}
