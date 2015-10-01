using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01BiggerNumber
{
    class Program
    {
         
        static int GetMax(int number1, int number2)
        {
            int max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
            return max;
        }

        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(number1, number2));
           
        }
    }
}
