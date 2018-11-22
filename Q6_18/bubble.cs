using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_18
{
    class bubble
    {
        public static int[] sort(params int[] nums)
        {
            int i = 0,temp=0;
            while(i<nums.Length-1)
            {
                if(nums[i]>nums[i+1])
                {
                    temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                    i = -1;
                }
                i++;
            }
            return nums;
        }
    }
}
