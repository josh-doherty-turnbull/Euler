using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem41 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.

What is the largest n-digit pandigital prime that exists?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Pandigital prime";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 41;
            }
        }

        protected override string Solve()
        {
            int result = 0;

            for (int i = 1; i < 10; i++)
            {
                string numberString = string.Empty;

                for (int j = 1; j <= i; j++)
                {
                    numberString += j.ToString();
                }

                int number = int.Parse(numberString);

                int[] permutations = number.GetPermutations();

                foreach (int candidate in permutations)
                {
                    if (PrimeHelper.IsPrime(candidate) &&
                        candidate > result)
                    {
                        result = candidate;
                    }
                }
            }

            return result.ToString("0");
        }
    }
}
