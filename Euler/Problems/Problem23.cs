using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem23 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Non-abundant sums";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 23;
            }
        }

        protected override string Solve()
        {
            //first get all abundant numbers in the relevant range
            IList<int> abundantNumbers = new List<int>();

            for (int i = 0; i <= 28123; i++)
            {
                if (NumberHelper.IsAbundant(i))
                {
                    abundantNumbers.Add(i);
                }
            }


            //build a list of all possible sums of those abundant numbers

            IList<int> abundantSums = new List<int>();

            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = i; j < abundantNumbers.Count; j++)
                {
                    int abundantSum = abundantNumbers[i] + abundantNumbers[j];

                    abundantSums.Add(abundantSum);
                }
            }


            abundantSums = abundantSums.Distinct().ToList();

            //build a third list of all numbers that do not exist in
            //the abundant sums list, and therefore are not expressable
            //as the sum of two abundant numbers

            IList<int> nonAbundantSums = new List<int>();

            for (int i = 0; i <= 28123; i++)
            {
                if (abundantSums.Any(f => f == i) == false)
                {
                    nonAbundantSums.Add(i);
                }
            }

            return nonAbundantSums.Sum().ToString("0");
        }
    }
}
