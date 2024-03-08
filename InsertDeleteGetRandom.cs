using System;
using System.Collections.Generic;

namespace LeetCodeSolutions 
{
    public class InsertDeleteGetRandom 
    {
        public static void Run()
        {
            // Example usage:
            var randomizedSet = new RandomizedSet();
            Console.WriteLine(randomizedSet.Insert(1)); // True, as the element was inserted
            Console.WriteLine(randomizedSet.Remove(2)); // False, as the element was not found
            Console.WriteLine(randomizedSet.Insert(2)); // True, as the element was inserted
            Console.WriteLine(randomizedSet.GetRandom()); // Returns 1 or 2 randomly
            Console.WriteLine(randomizedSet.Remove(1)); // True, as the element was removed
            Console.WriteLine(randomizedSet.Insert(2)); // False, as the element was already present
            Console.WriteLine(randomizedSet.GetRandom()); // Always returns 2
        }

        public class RandomizedSet 
        {
            // Declare a HashSet to store the elements. HashSet is chosen for its O(1) average time complexity for add, remove, and contains operations.
            private HashSet<int> MySet;
            
            // Declare a Random instance to generate random numbers. This is used for selecting a random element from MySet.
            private Random rand;

            public RandomizedSet() 
            {
                // Initialize MySet as a new HashSet of integers.
                MySet = new HashSet<int>();
                // Initialize rand as a new Random instance to generate random indices.
                rand = new Random();
            }
            
            public bool Insert(int val) 
            {
                // Check if the value already exists in MySet.
                // If it does, return false to indicate the value was not added (because it's a duplicate).
                if (MySet.Contains(val)) 
                {
                    return false;
                }
                // If the value does not exist, add it to MySet and return true to indicate the value was successfully added.
                MySet.Add(val);
                return true;
            }
            
            public bool Remove(int val) 
            {
                // Check if the value exists in MySet.
                // If it doesn't, return false to indicate the value was not removed (because it wasn't found).
                if (!MySet.Contains(val)) 
                {
                    return false;
                }
                // If the value exists, remove it from MySet and return true to indicate the value was successfully removed.
                MySet.Remove(val);
                return true;
            }
            
            public int GetRandom() 
            {
                // Check if MySet is either null or empty.
                // If so, throw an InvalidOperationException because a random element cannot be selected from an empty or null collection.
                if (MySet == null || MySet.Count == 0) 
                {
                    throw new InvalidOperationException("Cannot select a random element from an empty or null HashSet.");
                }

                // Generate a random index based on the count (size) of MySet.
                int randomIndex = rand.Next(MySet.Count);
                // Convert MySet to an array to access elements by index.
                // This is necessary because HashSet does not support direct index-based access.
                int[] array = new int[MySet.Count];
                MySet.CopyTo(array);
                // Return the element located at the random index of the newly created array.
                return array[randomIndex];
            }
        }
    }
}
