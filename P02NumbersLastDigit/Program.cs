

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02LastDigitOfNumber
{
    class Program
    {
       
        private static string PrintNumber(int num)
        {
            string[] lastDigit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = num % 10;
            return lastDigit[digit];
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintNumber(number));
        }
    }
}
