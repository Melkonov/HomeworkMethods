using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem5ReverseNumber
{
    class Program
    {
        static int ReverseNumber(int number)
        {
            int newNumber = 0;
            string countr = number.ToString();
            int count = countr.Length - 1;
            int counter = (int)Math.Pow(10, count);
            while (number > 0)
            {
                newNumber += (number % 10) * counter;
                number /= 10;
                counter /= 10;
            }
            return newNumber;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            double checker = double.Parse(number);
            if (checker - (int)checker == 0)
            {
                Console.WriteLine(ReverseNumber((int)checker));
            }
            else
            {
                int[] numbers = Array.ConvertAll(number.Split(','), int.Parse);
                numbers[0] = ReverseNumber(numbers[0]);
                numbers[1] = ReverseNumber(numbers[1]);
                numbers = numbers.Reverse().ToArray();
                Console.WriteLine(String.Join(",", numbers));
            }
        }
    }
}

