using System;

namespace Search_in_sorted_rotated_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1,3 }; // 5 1 3 // 5,6,7,8,9,10,11,12,1,2,3,4
            var target = 3;
            Console.WriteLine(Search(nums, target));
        }

        static int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target) return mid;
                if (nums[low] <= nums[mid]) // 3 4 5 6 0 1 2
                {
                    if (target >= nums[low] && target <= nums[mid])
                        high = mid;
                    else
                        low = mid + 1;
                }
                else // 5 6 0 1 2 3 4
                {
                    if (target >= nums[mid] && target <= nums[high])
                        low = mid;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
    }
}
