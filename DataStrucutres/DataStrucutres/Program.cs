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

            //Console.WriteLine(TwoSum([1, 2, 3, 4, 5, 6, 7], 8));
            //Console.ReadKey();

            var Queue = new UseQueues();

            Queue.AddSong(0);
            Queue.AddSong(1);

            Queue.Playsongs();
        }

        public static int[] TwoSum(int[] nums, int target)
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

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--) { 
                if (digits[i] < 9) { digits[i] += 1; return digits; }
                else { digits[i] = 0; }
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;  
            return result;
        }

        //public LinkedListNode<int> DeleteLinkedListNodes(LinkedListNode<int> head)
        //{
        //    Dictionary<LinkedListNode<int>, int> values = new Dictionary<LinkedListNode<int>, int>();

        //}

    }
}

