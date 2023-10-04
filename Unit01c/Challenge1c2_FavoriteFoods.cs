using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("Tell me your 3 favorite foods!");
            string[] foods = new string[3];

            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("Type one of your favorite foods!");
                foods[i] = Console.ReadLine();
            }
            foreach (string f in foods)
            {
                Console.WriteLine(f + " sounds really yummy!");
            }

        }
    }
}