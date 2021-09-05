using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine("Entered Number is Perfect Number");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Perfect Number");
            }
        }
    }
}
