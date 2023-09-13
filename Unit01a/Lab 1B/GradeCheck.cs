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
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
                Console.WriteLine("Great Job!");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("B");
                Console.WriteLine("Good Job!");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("C");
                Console.WriteLine("Decent!");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("D");
                Console.WriteLine("Could be better.");
            }
            else if (grade >= 0 && grade <= 59)
            {
                Console.WriteLine("F");
                Console.WriteLine("Needs Work!");
            }
            else
            {
                Console.WriteLine("Invalid. Please convert your score to a percentage.");
            }
        }
    }
}