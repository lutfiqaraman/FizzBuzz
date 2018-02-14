using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            foreach (var number in numbers)
            {
                if (number % 15 == 0)
                    Console.WriteLine(number + " is a fizz buzz number\n");
                else if (number % 3 == 0)
                    Console.WriteLine(number + " is a fizz number\n");
                else if (number % 5 == 0)
                    Console.WriteLine(number + " is a buzz number\n");
                else
                    Console.WriteLine(number + " is a normal number\n");
            }

            Console.ReadKey();
        }
    }
}
