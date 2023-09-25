using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("What is the temperature in Celsius right now?");
            int temp;
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 40 && temp <= 49)
            {
                Console.WriteLine("Keep cool and stay indoors when possible. It burning hot outside!");
            }
            else if (temp >= 30 && temp <= 40)
            {
                Console.WriteLine("Stay in the shade and drink plenty of water!");
            }
            else if (temp >= 20 && temp <= 29)
            {
                Console.WriteLine("Enjoy the warm weather!");
            }
            else if (temp >= 10 && temp <= 19)
            {
                Console.WriteLine("Enjoy the cool weather! Maybe bring a light jacket.");
            }
            else if (temp >= 0 && temp <= 9)
            {
                Console.WriteLine("Stay warm and don't forget your coat, gloves, and hat!");
            }
            else if (temp >= -10 && temp <= -1)
            {
                Console.WriteLine("Keep warm and stay indoors when possible. It's freezing outside!");
            }
            else
            {
                Console.WriteLine("Invalid or extreme temperature.");
            }

        }
    }
}