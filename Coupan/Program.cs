using System;

namespace Coupan
{
    class Program
    {
        static void Coupon(int n)
        {
            int[] ary = new int[n];
            int[] str = new int[n];
            for (int i = 1; i < n; i++)
             {
                 Random random = new Random();
                 int num = random.Next(1, 10);
                 ary[i] = num;    
             }
            Console.WriteLine("acutual array values");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ary[i]);
            }
            Console.WriteLine("distinct array values");

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                int cnt = 1;
                for (int k = 0; k < i; k++)
                {
                    if (ary[i] == ary[k])
                    {
                        cnt++;
                    }
               }
                str[j] = cnt;
                j++;
            }
            for (int i = 0; i < n; i++)
            {

                if (str[i] == 1)
                    Console.WriteLine(ary[i]);
            }
        }
        static void Main(string[] args)
        {
            int Number;
            Console.Write("Enter The Repetations For Random : ");
            Number = Convert.ToInt32(Console.ReadLine());
            Coupon(Number);
        }
    }
}
