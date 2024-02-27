using System;

namespace LeetCodeSolutions
{
    public class TwoSum
    {
        public static void Run()
        {
            int[] nums = new int[] { 2, 7, 11, 15 }; // Example input array
            int target = 9; // Example target
            int[] result = FindTwoSum(nums, target);

            if (result.Length > 0)
            {
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No two sum solution found.");
            }
        }

        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                int diff = target - n;

                if (prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff], i };
                }

                if (!prevMap.ContainsKey(n))
                {
                    prevMap.Add(n, i);
                }
            }

            return new int[0]; // Return an empty array if no solution is found
        }
    }
}
