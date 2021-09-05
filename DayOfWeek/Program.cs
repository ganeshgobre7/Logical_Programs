using System;

namespace DayOfWeek
{
    class Program
    {
        public static void dayOfWeek(int d,int m,int y)
        {
            String[] weekday = { "sunday", "monday", "tuesday", "wensday", "thursday", "friday", "satuerday" };
            int y0,x,m0,d0;
            y0 = y-(14- m) / 12;
            x = y0 +( y0 / 4 - y0 / 100 )+( y0 / 400);
            m0 = m + 12 *((14 - m) / 12) - 2;
            d0 = (d + x + 31*m0/ 12) % 7;
            Console.WriteLine("day of the week is :");
            Console.WriteLine(weekday[d0]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());

            dayOfWeek(date, month, year);

        }
    }
}
