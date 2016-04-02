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
                return @"Largest prime factor";
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
            long startingNumber = 600851475143;
            IEnumerable<long> finalAnswer = 
            findPrimeFactors(startingNumber);
            return finalAnswer.Max().ToString();
            
        }

        private IEnumerable<long> findPrimeFactors(long N)
        {
            List<long> PrimeFactors = new List<long>();

            for (long i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (isPrime(i))
                    {
                        PrimeFactors.Add(i);
                    }
                }
            }

            return PrimeFactors.Distinct();

        }

        private bool isPrime(long i)
        {
            if (i % 2 == 0)
            { return false;}
            for (long k = 3; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
