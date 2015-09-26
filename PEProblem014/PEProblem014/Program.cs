using System;
/*
 * The following iterative sequence is defined for the set of positive integers:
 * n → n/2 (n is even)
* n → 3n + 1 (n is odd)
* 
* Using the rule above and starting with 13, we generate the following sequence:
* 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
* 
* It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.
* Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
* 
* Which starting number, under one million, produces the longest chain?
* NOTE: Once the chain starts the terms are allowed to go above one million.
*/
namespace PEProblem014
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;
            
            string result = "";
            double tmp = 0;
            int count = 1;
            int longestCount = 0;
            for (int i = 2; i < 1000000; i++)
            {
                tmp = i;
                count = 1;
                while (tmp != 1)
                {
                    if (tmp % 2 == 0)
                    {
                        tmp = tmp / 2;
                    }
                    else
                    {
                        tmp = 3 * tmp + 1;
                    }
                    count++;
                }

                if (count > longestCount)
                {
                    longestCount = count;
                    result = i.ToString();
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
