using System;

namespace LeetCodeSolutions
{
    public class HIndex
    {
        public static void Run()
        {

            // Define an array of arrays
            int[][] citationArrays = new int[][]
            {
            new int[] {3, 0, 6, 1, 5},
            new int[] {0, 0, 0, 0},
            new int[] {0, 1, 3, 6, 20, 23, 25, 60, 100},
            new int[] {100},
            new int[] {1},
            new int[] {0},
            new int[] {0,1},
            new int[] {11, 15}
            };
            

            
            for ( int i = 0; i < citationArrays.Length; i++) {
                Console.WriteLine($"The h-index of { citationArrays[i]} is {HIndexRank(citationArrays[i])}");
            }
        }
        public static int HIndexRank(int[] citations)
        {
            // edge case, if the array is empty return zero
            if (citations.Length == 0) return 0;
            // edge case, if the array's Length is 1
            if (citations.Length == 1) return citations[0] >= 1 ? 1 : 0;
            // sort the array in descending order
            Array.Sort(citations, (a, b) => b - a);
            // iterate over the array, if i (rank) is less than or equal to the citation, that's the h index, return i.  i will always give you the previous number to the element that has less citations than rank position
            for (int i = 0; i < citations.Length; i++) {
               
                if (i >= citations[i]) {
                return i;
                }
            }
            // continue the loop otherwise, return sort.Length if all citations exceed rank.
            return citations.Length;
        }
    }
};