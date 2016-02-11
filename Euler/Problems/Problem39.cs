using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem39 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

{20,48,52}, {24,45,51}, {30,40,50}

For which value of p ≤ 1000, is the number of solutions maximised?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Integer right triangles";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 39;
            }
        }

        protected override string Solve()
        {
            IDictionary<int, int> values = new Dictionary<int, int>();

            for (int i = 1; i < 1001; i++)
            {
                values.Add(i, 0);
            }

            for (int a = 1; a < 1000; a++)
            {
                for (int b = a; b < 1000; b++)
                {
                    for (int c = b; c < 1000; c++)
                    {
                        if ((a + b + c <= 1000) &&
                            (a * a + b * b == c * c))
                        {
                            values[a + b + c]++;
                        }
                    }
                }
            }

            KeyValuePair<int, int> bestP = values.OrderByDescending(o => o.Value).First();
            return bestP.Key.ToString("0");
        }
    }
}
