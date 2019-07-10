using System;
using System.Collections.Generic;

namespace RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given nums = [0,0,1,1,1,2,2,3,3,4],
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            RemoveDuplicates(nums);

        }

        static int RemoveDuplicates(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[j] != nums[i]){
                    j++;
                    nums[j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}
