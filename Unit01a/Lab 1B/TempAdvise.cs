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
            string result = (temp > 30) ? "Stay in the shade and drink plenty of water!" : "Enjoy the nice weather!";
            Console.WriteLine(result);
        }
    }
}