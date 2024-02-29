using System;
// Leetcode 55
namespace LeetCodeSolutions 
{
    public class JumpGame
    {
        public static void Run() // Changed status to void and added static
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            int[] nums2 = { 3, 2, 1, 0, 4};
            Console.WriteLine($"The end of the array nums {(canJump(nums) ? "can" : "cannot")} be reached.");
            Console.WriteLine($"The end of the array nums2 {(canJump(nums2) ? "can" : "cannot")} be reached.");
        }

        public static bool canJump(int[] nums)
        {
            int maxReach = 0; // The furthest we can reach
            int goal = nums.Length - 1; // Changed length to Length
  
            for (int i = 0; i <= maxReach && i <= goal; i++) 
            {
                maxReach = Math.Max(maxReach, i + nums[i]); // Changed math.max to Math.Max
                if (maxReach >= goal) 
                {
                    return true;
                }
            }
  
            return false;
        }
    }
}