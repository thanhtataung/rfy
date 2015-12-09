

using RfyRedPill.BusinessLogic.Model;
using System;
using System.Linq;

namespace RfyRedPill.BusinessLogic
{
    public class RedPillController
    {
        /// <summary>
		/// Reverses the words in a string.
        /// Swap by first and last index, so no need to index and read whole string
        /// Performance will different when the word bacomes very long
		/// </summary>
		public static string ReverseWords(string inputStr)
        {
            if ((inputStr + "").Length > 1)
            {
                char[] charArr = inputStr.ToCharArray();
                int halfLength = inputStr.Length / 2;
                int startIndex = 0;
                int endIndex = inputStr.Length - startIndex - 1;

                while ((startIndex != endIndex) && (startIndex < endIndex))
                {
                    char temp = charArr[startIndex];
                    charArr[startIndex] = charArr[endIndex];
                    charArr[endIndex] = temp;

                    startIndex++;
                    endIndex = inputStr.Length - startIndex - 1;
                }

                //Take 8ms to run the test,
                //for(int index= (inputStr.Length - 1); index > -1; index--)
                //{
                //    charArr[(inputStr.Length - index - 1)] = inputStr[index];
                //}
                return new string(charArr);
            }
            else
            {
                return inputStr + "";
            }
        }

        

        public static TriangleType WhatShapeIsThis(int a, int b, int c)
        {

            int[] values = new int[3] { a, b, c };


            if ((a <= 0 || b <= 0 || c <= 0) || //First Check minus value
                ((a + b <= c) || (b + c <= a) || (a + c <= b))) // check is that triangle, combine 2 must greater than another
            {
                return TriangleType.Error;
            }
            switch (values.Distinct().Count())
            {
                case 1: return TriangleType.Equilateral; // All sides are same
                case 2: return TriangleType.Isosceles; //2 sides are equal
                case 3: return TriangleType.Scalene; //None of the the sides are equal
                default: return TriangleType.Error;
            }
        }

        /// <summary>
        /// Recursive get Fiboacci
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciNumber(long n)
        {
            if (n < Constant.MinIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(<92) will cause a 64-bit integer overflow.");
            }

            if (n > Constant.MaxIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n", "Sorry I don't know how to calculate negative number.");
            }
            return GetNthFibonacci_Rec(n);
        }


        public static long GetNthFibonacci_Rec(long n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }

        


        /// <summary>
        /// Performance problem look like because of recursive function
        /// So change with for loop
        /// </summary>
        public static long GetFibonacci(long n)
        {
            if (n < Constant.MinIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(<92) will cause a 64-bit integer overflow.");
            }

            if (n > Constant.MaxIndex)
            {
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            }

            if (n == 0)
            {
                return 0;
            }

            long n1 = 1;
            long n2 = 1;
            var absIndex = Math.Abs(n);

            for (var i = 2; i < absIndex; i++)
            {
                var tmp = n1;
                n1 = n2;
                n2 = n1 + tmp;
            }

            //Should clarify the requirement this part, based on wiki, it might not be same value for negative fibonnanci
            //https://en.wikipedia.org/wiki/Generalizations_of_Fibonacci_numbers#Extension_to_negative_integers
            return n < 0 && absIndex % 2 == 0 ? -n2 : n2;
        }
    }
}
