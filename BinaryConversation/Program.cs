using System;

namespace BinayConversation
{
    class Program
    {
        public static void toBinary(int num)
        {
            int i;
            int[] array = new int[8];
            for (i = 0; num > 0; i++)
            {
                array[i] = num % 2;
                num = num / 2;
            }
            Console.Write("Binary Numbers is : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            toBinary(Number);
        }
    }
}