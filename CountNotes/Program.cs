using System;

namespace CountNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount to get the minimum values of the notes");
            int amt = Convert.ToInt32(Console.ReadLine());

            int [] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            for (int i = 0;  i < notes.Length;i++)
            {
                if (amt >= notes[i]) 
                {
                    Console.WriteLine(notes[i] + "=" + amt / notes[i] + " notes");
                    amt = amt % notes[i]; 
                }
            }
        }
    }
}
