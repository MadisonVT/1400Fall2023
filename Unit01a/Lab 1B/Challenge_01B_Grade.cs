using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("What is your exam score as a percentage?");
            int grade;
            grade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite subject?");
            string fave;
            fave = Console.ReadLine();

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("Great Job!");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("---Good Job!---");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("---Decent!---");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("---Could be better.---");
            }
            else if (grade >= 0 && grade <= 59)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("---Needs Work!---");
            }
            else
            {
                Console.WriteLine("---Invalid. Please convert your score to a percentage.---");
            }
            switch (fave)
            {
                case "Math":
                    Console.WriteLine("Math is awesome! Keep working hard and learning new equations. :D ");
                    break;
                case "Science":
                    Console.WriteLine("Science is cool! Keep working hard and learning about the world. :P ");
                    break;
                case "English":
                    Console.WriteLine("English is a great subject! Keep working hard and read new books! :) ");
                    break;
                case "Art":
                    Console.WriteLine("Art is fun! Keep working hard and learning new techniques :3 ");
                    break;
                default:
                    Console.WriteLine("Please simplify your favorite subject into core subjects (Math, Science, ect).");
                    break;
            }
        }
    }
}