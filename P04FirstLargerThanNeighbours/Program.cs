using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };
            bool check = false;

            for (int i = 0; i < sequenceOne.Length; i++)
            {
                if(FirstLargerThanNeighbours(sequenceOne,i) == true )
                {
                    Console.WriteLine(i);
                    check = true;
                    break;
                }
            }
            if(!check)
            {
                Console.WriteLine(-1);
            }
            check = false;

            for (int i = 0; i < sequenceTwo.Length; i++)
            {
                if (FirstLargerThanNeighbours(sequenceTwo, i) == true)
                {
                    Console.WriteLine(i);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine(-1);
            }
            check = false;

            for (int i = 0; i < sequenceThree.Length; i++)
            {
                if (FirstLargerThanNeighbours(sequenceThree, i) == true)
                {
                    Console.WriteLine(i);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine(-1);
            }

        }


            static bool FirstLargerThanNeighbours(int[] nums, int i)
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
