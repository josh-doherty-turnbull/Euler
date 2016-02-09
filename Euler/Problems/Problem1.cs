using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem1 : BaseProblem
    {

        public override string ProblemDescription
        {
            get
            {
                return @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Multiples of 3 and 5";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 1;
            }
        }

        protected override string Solve()
        {
            int result = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += i;
                }
            }

            return result.ToString("0");
        }
    }
}
