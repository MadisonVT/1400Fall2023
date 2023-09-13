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
            }
            else if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("B");
            }
        }
    }
}