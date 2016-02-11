using Euler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem34 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.

Find the sum of all numbers which are equal to the sum of the factorial of their digits.

Note: as 1! = 1 and 2! = 2 are not sums they are not included.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Digit factorials";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 34;
            }
        }

        protected override string Solve()
        {
            int result = 0;

            //build a lookup list of digit factorials to prevent
            //multiple processing
            int[] factorials = new int[10];

            for (int i = 0; i < 10; i++)
            {
                factorials[i] = (int)NumberHelper.FactorialOf(i);
            }

            for (int i = 3; i < NumberHelper.FactorialOf(9)*7; i++)
            {
                IEnumerable<int> digits = NumberHelper.GetDigits(i);

                int sumOfFactorial = 0;

                foreach (int digit in digits)
                {
                    sumOfFactorial += factorials[digit];
                    if (sumOfFactorial > i) break; // performance stop
                }

                if (sumOfFactorial == i)
                {
                    result += i;
                }
            }

            return result.ToString("0");
        }
    }
}
