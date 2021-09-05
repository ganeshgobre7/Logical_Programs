using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, revNo=0, rem;
            Console.WriteLine("Enter the Number You Want to Reverse");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                rem = num % 10;
                revNo = revNo * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine("Reverse Number is:" + revNo);
        }
    }
}
