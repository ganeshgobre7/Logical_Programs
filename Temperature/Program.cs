using System;

namespace Temperature
{
    class Program
    {
        public static double convertToFer(double celTemp)
        {
            double ferTemp = 0;
            ferTemp = (celTemp * 9) / 5 + 32;
            return ferTemp;
        }
        static void Main(string[] args)
        {
            double celTemp = 0;
            double ferTemp = 0;
          
            Console.WriteLine("Enter the Value of Temparature in Celcius");
            celTemp = double.Parse(Console.ReadLine());

            ferTemp = convertToFer(celTemp);
            Console.WriteLine("Fahrenheit temparature is:" + ferTemp);  
        }
    }
}
