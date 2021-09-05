using System;

namespace MonthlyPayment
{
    class Program
    {
        public static void monthlyPayment(double p,double y,double r)
        {
            double n = 12 * y;
            r = r / (12 * 100);
            double payment = (p * r) / (1 - Math.Abs(Math.Pow((1 + r), (-n))));
            Console.WriteLine("Total Monthly Payment is:"+ payment);
        }
        static void Main(string[] args)
        {
            double p, y, r;

            Console.WriteLine("Enter the Loan Amount");
            double amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Year");
            double year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Monthly Intrest");
            double intrest = Convert.ToInt32(Console.ReadLine());

            monthlyPayment(amount,year,intrest);
        }
    }
}
