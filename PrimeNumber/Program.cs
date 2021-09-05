using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;           
            Boolean flag = true;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i=2;i<number;i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is Not Prime");
            }
        }
    }
}
