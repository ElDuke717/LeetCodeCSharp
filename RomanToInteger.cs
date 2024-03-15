using System;

namespace LeetCodeSolutions
{
    public class RomanToInteger
    {
        public static void Run() 
        {
            string[] romanNumerals = new string[]
            {
                "III",
                "XVI",
                "MCMXCIV",
                "LVIII"
            };
             for ( int i = 0; i < romanNumerals.Length; i++) {
                Console.WriteLine($"The Length of the last word in [{String.Join(", ", romanNumerals[i])}] is {RomanToInt(romanNumerals[i])}");
            }
        }
        public static int RomanToInt(string s) 
        {
            var map = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            
            // Directly return the value if the string length is 1
            if (s.Length == 1) return map[s[0]];
            
            int res = 0;
            for (int i = 0; i < s.Length - 1; i++) { // Notice the "s.Length - 1" to avoid going out of bounds
                if (map[s[i]] < map[s[i + 1]]) {
                    // Subtract if the current Roman numeral is less than the next one
                    res -= map[s[i]];
                } else {
                    // Add if the current Roman numeral is greater than or equal to the next one
                    res += map[s[i]];
                }
            }
            
            // Always add the value of the last Roman numeral to the result
            res += map[s[s.Length - 1]];
            
            return res;
        }

    }
}