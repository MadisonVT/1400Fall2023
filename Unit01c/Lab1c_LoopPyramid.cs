using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("How many rows do you want your pyramid to have?");
            int num_rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num_rows + " rows selected.");

            for (int i = 1; i <= num_rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }

        }
    }
}