using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Helpers
{
    class SieveOfEratosthenes
    {
        public static bool[] RunSieve (long upperBound)
        {
            bool[] primeCandidates = new bool[upperBound + 1];

            for (int i = 0; i < upperBound + 1; i++)
            {
                primeCandidates[i] = true;
            }

            primeCandidates[0] = false;
            primeCandidates[1] = false;

            for (int i = 2; i < upperBound + 1; i++)
            {
                if (primeCandidates[i])
                {
                    for (int k = i * 2; k < upperBound + 1; k += i)
                    {
                        primeCandidates[k] = false;
                    }
                }
            }

            return primeCandidates;
        }
    }
}
