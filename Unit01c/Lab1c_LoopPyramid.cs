using System;
namespace Program
{
    public class Programs
    {
        public static void Main()
        {
            Console.WriteLine("Choose the amount of rows you want your number pyramid to have!");
            int rows = Convert.ToInt32(Console.ReadLine());
            int startnum = 1;
            while (rows >= startnum)
            {
                int[] num_rows = { startnum };
                Console.WriteLine(startnum);
                startnum++;
                for (int i = 0; i < num_rows.Length;)
                {
                    Console.WriteLine(num_rows[i]);
                    i++;
                }

            }

        }
    }
}