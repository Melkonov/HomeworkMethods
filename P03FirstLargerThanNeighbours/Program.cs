using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(LargerThanNeighbours(numbers,i));
            }
            
        }

        static bool LargerThanNeighbours(int[] nums, int i)
        {
            bool isLarger = false;
            if(i > 0 && i+1 < nums.Length - 1)
            {
                if (nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
                {
                    isLarger = false;
                }
                else if (nums[i - 1] > nums[i] && nums[i] > nums[i + 1])
                {
                    isLarger = false;
                }
                else if (nums[i - 1] < nums[i] && nums[i] > nums[i + 1])
                {
                    isLarger = true;
                }
                return isLarger;
               
            }
            else
            {
                if (i ==0 && nums[i] < nums[i+1])
                {
                    isLarger = false;
                }
                else if(i== nums.Length - 1 && nums[i] > nums[i-1])
                {
                    isLarger = true;
                }
                return isLarger;
            }
           
        }
    }
}
