using System;

namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;

            if (num < 5)
            {
                Console.WriteLine("The number is less than 5");
            }
            else if (num >= 5 && num < 10)
            {
                Console.WriteLine("The number is between 5 and 10");
            }
            else
            {
                Console.WriteLine("The number is greater than or equal to 10");
            }
        }
    }
}