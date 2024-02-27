using System;

namespace LeetCodeSolutions // Use your actual project's namespace
{
    public class RemoveDuplicates // Class name matches the file name
    {
        public static void Run()
        {
            // Example usage:
            int[] nums = {1, 1, 1, 2, 2, 3};
            int result = RemoveDuplicatesFromArray(nums);
            
            // Output the result to the terminal
            Console.WriteLine($"Array after removing duplicates has length: {result}");
            for (int i = 0; i < result; i++) {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // New line for clean output
        }

        // Renamed method to avoid naming conflict with the class name
        public static int RemoveDuplicatesFromArray(int[] nums)
        {
            if (nums.Length == 0) return 0; // Edge case for an empty array

            int j = 1; // Pointer for the unique element position 
            int count = 1; // Tracks occurrences of the current element

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[j++] = nums[i];
                }
            }

            return j; // j points to the next unique element position, hence, it represents the length of the unique array
        }
    }
}
