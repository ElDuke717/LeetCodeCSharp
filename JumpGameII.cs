using System;

namespace LeetCodeSolutions
{
    public class JumpGameII 
    {
        public static void Run()
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            int[] nums2 = { 3, 2, 1, 0, 4};
            Console.WriteLine($"The steps to the end of the array nums is {(jumpGame(nums))}.");
            Console.WriteLine($"The steps to the end of the array nums2 is {(jumpGame(nums2))}.");
        }

        public static int jumpGame(int[] nums) 
        {
            if (nums.Length <= 1) return 0;
            int maxReach = nums[0]; // The furthest we can reach after the first jump
            int nextMaxReach = nums[0]; // The furthest we can reach on the next jump
            int count = 1; // Start count at 1 because a jump from the first position is always needed unless the array has a single element
            
            for (int i = 1; i < nums.Length; i++) { // Start from second element
                if (i > maxReach) {
                    // If i is beyond maxReach, it means we can't reach this point
                    return -1;
                }
                nextMaxReach = Math.Max(nextMaxReach, i + nums[i]);
                if (i == maxReach && i < nums.Length - 1) { // Only increment count if we've reached maxReach and we're not at the last element
                    maxReach = nextMaxReach;
                    count++;
                }
            }
            return count;
        }


    }
}