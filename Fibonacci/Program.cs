using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int q = 1;
            int temp = 0;

            Console.WriteLine("Enter How Many Terms You Want");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series of Entered terms is");

            Console.WriteLine(p);
            Console.WriteLine(q);

            for (int i = 2; i < input; i++)
            {
                temp = p + q;
                Console.WriteLine(temp);
                p = q;
                q = temp;

            }
        }
    }
}
