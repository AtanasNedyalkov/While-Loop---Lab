using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            while (input != "Stop")
            {
                int n = int.Parse(input);
                if (n>maxNumber)
                {
                    maxNumber = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
