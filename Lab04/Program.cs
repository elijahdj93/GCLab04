using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing == true)
            { 
            long i, number , fact;
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Console.WriteLine();
            Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
            number = long.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            
            string userChoice;
            Console.WriteLine("Continue? (y/n)");
            userChoice = Console.ReadLine();
            if (userChoice == "n" || userChoice == "N")
            {
                keepGoing = false;
            }
            }
        }
    }
}
