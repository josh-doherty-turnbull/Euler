using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Helpers
{
    class FibonacciHelper
    {
        public static IEnumerable<long> GetSequenceFromMax(long max)
        {
            IList<long> sequence = new List<long>();

            int a = 0;
            int b = 1;
            
            for (int i = 0; true; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (a < max)
                {
                    sequence.Add(a);
                }
                else
                {
                    break;
                }
            }
            return sequence;
        }

        public static IEnumerable<long> GetSequenceFromElementCount(long elementCount)
        {
            IList<long> sequence = new List<long>();

            int a = 0;
            int b = 1;

            for (int i = 0; i < elementCount; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                sequence.Add(a);
            }
            return sequence;
        }
    }
}
