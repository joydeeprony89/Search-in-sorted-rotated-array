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
           int l = 0;
          int r = nums.Length -1;
          while(l <= r){
            int mid = l + (r - l)/2;
            if(nums[mid] == target) return mid;
            // check for left sorted portion
            else if(nums[l] <= nums[mid]){
              // When left sorted check target belongs to left portion or to right of mid
              // 4,5,6,7,0,1,2 - so left portion would be 4, 5, 6, 7 and target 0 < nums[mid] , 0 < 7 , so we got to know as 0 < 7 so we have to search left side portion ,but 0 also less than nums[l], i.e 4, 0 < 4. As we can not find the target 0 in left portion target can be available at right portion.
              if(target < nums[l] || target > nums[mid])
                l = mid + 1;
              else
                r = mid -1;
            } else {
              if(target > nums[r] || target < nums[mid])
                r = mid -1;
              else
                l = mid + 1;
            }
          }

          return -1;
        }
    }
}
