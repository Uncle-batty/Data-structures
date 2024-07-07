using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Palindrome palindrome = new Palindrome("SSuss");
            //Console.WriteLine(palindrome.isplai);

            Console.WriteLine(TwoSum([1,2,3,4,5,6,7], 8))
            Console.ReadKey();
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

    }
}

