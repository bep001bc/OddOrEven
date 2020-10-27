using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd();
        }

        public static bool IsOdd() 
        {
            Console.WriteLine($"Enter a number");
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 != 0)
            {
                Console.WriteLine($"Your number is odd");
                return true;
            }
            else
            {
                Console.WriteLine($"Your number is even");
                return false;
            }
        }
    }
}
