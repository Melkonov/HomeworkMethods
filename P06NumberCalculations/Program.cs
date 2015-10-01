using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06NumberCalculationse
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = { 2.5, 4.6, 6.8, 9.7, 3.9 };
            decimal[] decimals = { 1, 2, 3, 4, 5, };
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Avg: {3}, Product: {4}", GetMin(doubles),GetMax(doubles),GetSum(doubles),GetAvg(doubles),GetProduct(doubles));
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Avg: {3}, Product: {4}", GetMin(decimals), GetMax(decimals), GetSum(decimals), GetAvg(decimals), GetProduct(decimals));
            

        }
        static decimal GetMin(decimal[] numbers)
        {
            decimal min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]<min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        static double GetMin(double[] numbers)
        {
            double min = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
			{
			 if (numbers[i] < min)
             {
                 min = numbers[i];
             }
			}
            return min;
        }
        static decimal GetMax(decimal[] numbers)
        {
            decimal max = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
			{
			  if(numbers[i] > max)
              {
                  max = numbers[i];
              }
			}
                return max;
        }
        static double GetMax(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        static decimal GetSum(decimal[] numbers)
        {
            decimal sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static double GetSum(double[] numbers)
        {
            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static decimal GetAvg(decimal[] numbers)
        {
            return GetSum(numbers) / numbers.Length;
        }
        static double GetAvg(double[] numbers)
        {
            return GetSum(numbers) / numbers.Length;
        }
        static decimal GetProduct(decimal[] numbers)
        {
            decimal product = 1;
                for (int i = 0; i < numbers.Length; i++)
			{
                product *= numbers[i];
			}
                return product;
        }
        static double GetProduct(double[] numbers)
        {
            double product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
       
    }
}
