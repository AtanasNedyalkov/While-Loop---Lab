using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (input != "Stop")
            {
                int n = int.Parse(input);
                if (n < minNumber)
                {
                    minNumber = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
