using System;
namespace BasicCSharpPart2Homework4
{
    public class FibonacciSum
    {
        public static int SumEvenValuedTermsUpToLimit(int limit)
        {
            //variables are initialized to the first two terms of the sequence
            int a = 1;
            int b = 2;

            //variable is initialized to 0 to store the sum of the even-valued terms
            int sum = 0;

            while (a <= limit)
            {
                //checks if 'a' is even
                if (a % 2 == 0)
                {
                    //if 'a' is even, adds 'a' to sum
                    sum += a;
                }

                //calculates the next term in the sequence by adding 'a' and 'b' 
                int c = a + b;
                //updates the values of 'a' and 'b'
                a = b;
                b = c;
            }
            return sum;
        }
    }
}
