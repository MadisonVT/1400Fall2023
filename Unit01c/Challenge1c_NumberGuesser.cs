using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            //Generating a number between 1 and 10 and storing it in a variable//
            int random_number = new Random().Next(1, 10);
            //Asking user to guess the number and putting their answer into a variable//
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");
            int user_number = Convert.ToInt32(Console.ReadLine());
            //Asking the user continuously until the number they give is the same as the random one//
            while (user_number != random_number)
            {
                //Telling the user the number is higher or lower than what they guessed//
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
                //Allowing user to guess again after getting the wrong answer//
                Console.WriteLine("Guess again!");
                user_number = Convert.ToInt32(Console.ReadLine());
            }
            //Congratulating user and ending game when they guess the correct number//
            if (user_number == random_number)
            {
                Console.WriteLine("Correct! The number was " + random_number + "!");
            }

        }
    }
}