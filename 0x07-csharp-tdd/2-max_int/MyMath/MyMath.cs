using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Class holding methods that perform operations.</summary>
    public class Operations
    {
        /// <summary>Finds max in list of nums.</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            int result = nums[0];
            foreach (int number in nums)
                if (number > result)
                    result = number;
            return result;
        }
    }
}
