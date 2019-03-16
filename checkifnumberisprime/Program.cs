using System;

namespace checkifnumberisprime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 2) Console.WriteLine("False");

            else if (number == 2) Console.WriteLine("True");

            else if (number == 3) Console.WriteLine("True");

            else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
                Console.WriteLine("False");
            
            else Console.WriteLine("True");


            Console.ReadLine();
        }
    }
}