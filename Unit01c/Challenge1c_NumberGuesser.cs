using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            int random_number = new Random().Next(1, 10);
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");
            int user_number = Convert.ToInt32(ReadLine());
            if user_number == random_number
            {
                Console.WriteLine("That is correct! It was " + random_number + "!");
            }
            else if user_number < random_number
            {
                Console.WriteLine("It's higher than that.");

            }
            else
            {
                Console.WriteLine("It's lower than that.");
            }
        }
    }
}