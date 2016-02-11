using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem31 : BaseProblem
    {
        public override string ProblemDescription
        {
            get
            {
                return @"In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
It is possible to make £2 in the following way:

1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
How many different ways can £2 be made using any number of coins?";
            }
        }

        public override string ProblemName
        {
            get
            {
                return "Coin sums";
            }
        }

        public override int ProblemNumber
        {
            get
            {
                return 31;
            }
        }

        protected override string Solve()
        {
            int result = 0;

            for (int onePence = 0; onePence < 201; onePence++)
            {
                for (int twoPence = 0; twoPence < 101; twoPence++)
                {
                    for (int fivePence = 0; fivePence < 41; fivePence++)
                    {
                        for (int tenPence = 0; tenPence < 21; tenPence++)
                        {
                            for (int twentyPence = 0; twentyPence < 11; twentyPence++)
                            {
                                for (int fiftyPence = 0; fiftyPence < 5; fiftyPence++)
                                {
                                    for (int onePound = 0; onePound < 3; onePound++)
                                    {
                                        for (int twoPound = 0; twoPound < 2; twoPound++)
                                        {
                                            if (onePence * 1 + 
                                                twoPence * 2 + 
                                                fivePence * 5 + 
                                                tenPence * 10 + 
                                                twentyPence * 20 +
                                                fiftyPence * 50 + 
                                                onePound * 100 + 
                                                twoPound * 200 == 200) result++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result.ToString("0");
        }
    }
}
