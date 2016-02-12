using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Helpers
{
    class NumberHelper
    {
        public static bool IsPerfect(long number)
        {
            IEnumerable<long> divisors = PrimeHelper.GetProperDivisors(number);

            if (divisors.Sum() == number) return true;

            return false;
        }

        public static bool IsAbundant(long number)
        {
            IEnumerable<long> divisors = PrimeHelper.GetProperDivisors(number);

            if (divisors.Sum() > number) return true;

            return false;
        }

        public static bool IsDeficient(long number)
        {
            IEnumerable<long> divisors = PrimeHelper.GetProperDivisors(number);

            if (divisors.Sum() < number) return true;

            return false;
        }

        /// <summary>
        /// Returns an enumerable of the digits within a number, in their
        /// left to right order of the number
        /// </summary>
        /// <param name="number">The number to convert to digits</param>
        /// <returns>Enumerable of ints</returns>
        public static IEnumerable<int> GetDigits(long number)
        {
            long n = number;
            IList<int> digits = new List<int>();

            do
            {
                digits.Add((int)(n % 10));
                n /= 10;

            } while (n > 0);

            return digits.Reverse().ToList();
        }

        /// <summary>
        /// Gets all the rotations of a given number, for instance an input of
        /// 123 would return an enumerable of 123, 231 & 312
        /// -- The implementation of this method has O(n2) complexity for n digits
        /// in a number, so bear that in mind for performance
        /// </summary>
        /// <param name="number">The number to rotate</param>
        /// <returns>An enumerable of numbers that are rotations of the input</returns>
        public static IEnumerable<long> GetRotations(long number)
        {
            IList<int> digits = GetDigits(number).ToList();
            IList<long> rotations = new List<long>();

            for (int i = 1; i <= digits.Count; i++)
            {
                int removedDigit = digits[0];
                digits.RemoveAt(0);
                digits.Add(removedDigit);

                long rotation = 0;

                foreach (int digit in digits)
                {
                    rotation *= 10;
                    rotation += digit;
                }

                rotations.Add(rotation);
            }

            return rotations;
        }

        /// <summary>
        /// Returns the factorial of the input number
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>factorial as long</returns>
        public static long FactorialOf(long number)
        {
            if (number == 0) return 1;

            long result = number;

            for (int i = 1; i < number; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Returns the value of the triangle number sequence equal
        /// to the index specified, in accordance with Tn=n(n+1)/2
        /// </summary>
        /// <param name="index">The index of the sequence to return</param>
        /// <returns>Triangle number</returns>
        public static long GetTriangleNumber(long index)
        {
            return index * (index + 1) / 2;
        }

        /// <summary>
        /// Evaluates whether or not the input number is a Triangle number
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>True or false</returns>
        public static bool IsTriangle(long number)
        {
            if (number == 0) return true;

            long n = 0;

            for (int i = 1; n < number; i++)
            {
                n = GetTriangleNumber(i);
                if (n == number) return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the value of the pengtagonal number sequence equal
        /// to the index specified, in accordance with Pn=n(3n−1)/2
        /// </summary>
        /// <param name="index">The index of the sequence to return</param>
        /// <returns>Pentagonal number</returns>
        public static long GetPentagonalNumber(long index)
        {
            return index * (3 * index - 1) / 2;
        }
        
        /// <summary>
        /// Evaluates whether or not the input number is a pentagon number
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>True or false</returns>
        public static bool IsPentagon(long number)
        {
            if (number == 0) return true;

            long n = 0;

            for (int i = 1; n < number; i++)
            {
                n = GetPentagonalNumber(i);
                if (n == number) return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the value of the hexagonal number sequence equal
        /// to the index specified, in accordance with Hn=n(2n−1)
        /// </summary>
        /// <param name="index">The index of the sequence to return</param>
        /// <returns>Hexagonal number</returns>
        public static long  GetHexagonalNumber(long index)
        {
            return index * (2 * index - 1);
        }

        /// <summary>
        /// Evaluates whether or not the input number is a hexagon number
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>True or false</returns>
        public static bool IsHexagon(long number)
        {
            if (number == 0) return true;

            long n = 0;

            for (int i = 1; n < number; i++)
            {
                n = GetHexagonalNumber(i);
                if (n == number) return true;
            }

            return false;
        }

        /// <summary>
        /// Evaluates whether a number is n digit pandigital for its length (containing
        /// all digits 1 to n for a number n digits long), e.g.
        /// 1234 is pandigital for n=4
        /// </summary>
        /// <param name="number">The number to check</param>
        /// <returns>True or false whether the number is pandigital</returns>
        public static bool IsPandigital(long number)
        {
            IEnumerable<int> digits = GetDigits(number);
            int length = digits.Count();

            if (digits.Count(d => d == 0) > 0) return false;

            for (int i = 1; i <= length; i++)
            {
                if (digits.Count(d=>d == i) != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
