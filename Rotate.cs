using System;

namespace LeetCodeSolutions // Adjusted to the project's namespace
{
    public class Rotate
    {
        public static void Run()
        {
            // Example usage:
            int[] nums = {1, 2, 3, 4, 5, 6, 7};
            int k = 3; // Example rotation value

            // Call Rotate directly since it's now a static method
            RotateArray(nums, k);

            // Output the result to the terminal
            Console.WriteLine("Rotated array:");
            Console.WriteLine(string.Join(", ", nums));
        }

        public static void RotateArray(int[] nums, int k) // Method name changed to avoid class name conflict and made static
        {
            // Handle rotations larger than array length - use the remainder for k
            k = k % nums.Length;

            // Step 1: Reverse the whole array
            Reverse(nums, 0, nums.Length - 1);
            // Step 2: Reverse the first k elements
            Reverse(nums, 0, k - 1);
            // Step 3: Reverse the rest
            Reverse(nums, k, nums.Length - 1);
        }

        // Helper function to reverse a portion of the array; made static to be accessible from static methods
        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
