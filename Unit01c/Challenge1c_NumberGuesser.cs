using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            int random_number = new Random().Next(1, 10);
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");
            int user_number = Convert.ToInt32(Console.ReadLine());
            while (user_number != random_number)
            {
                if (user_number > random_number)
                {
                    Console.WriteLine("It's lower than that.");
                }
                else if (user_number < random_number)
                {
                    Console.WriteLine("It's higher than that.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Pick a number between 1 and 10.");
                }
                Console.WriteLine("Guess again!");
                user_number = Convert.ToInt32(Console.ReadLine());
            }
            if (user_number == random_number)
            {
                Console.WriteLine("Correct! The number was " + random_number + "!");
            }

        }
    }
}