using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem36 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.

Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.

(Please note that the palindromic number, in either base, may not include leading zeros.)";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Double-base palindromes";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 36;
            }
        }

        protected override string Solve()
        {
            long result = 0;

            for (int i = 1; i < 1000000; i++)
            {
                string base10 = i.ToString();
                string base10reversed = new string(base10.Reverse().ToArray());

                if (base10 == base10reversed)
                {
                    string base2 = Convert.ToString(i, 2);
                    string base2reversed = new string(base2.Reverse().ToArray()); 

                    if (base2 == base2reversed)
                    {
                        result += i;
                    }
                }
            }

            return result.ToString();
        }
    }
}
