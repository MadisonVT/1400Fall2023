using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            //Setting up user to answer question and creating an array that holds 3 items//
            Console.WriteLine("Tell me your 3 favorite foods!");
            string[] foods = new string[3];
            //Asking user for their input and putting it into the array//
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("Type one of your favorite foods!");
                foods[i] = Console.ReadLine();
            }
            //Printing each item in the array to the console and adding a message after what they put//
            foreach (string f in foods)
            {
                Console.WriteLine(f + " sounds really yummy!");
            }

        }
    }
}