using System;

namespace LeetCodeSolutions
{
    public class LongestCommonPrefix
    {
        public static void Run()
        {
            string[][] stringArray = new string[][]
            {
                new string[] {"flower","flow","flight"},
                new string[] {"dog","racecar","car"}
            };
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(prefixChecker(stringArray[i]).Length > 0 ? 
                $"The longest common prefix in the array {String.Join(", ", stringArray[i])} is {prefixChecker(stringArray[i])}" : 
                $"There is no common prefix in {String.Join(", ", stringArray[i])}.");

            }
        }

        public static string prefixChecker(string[] strings) 
        {
            if (strings.Length == 0) {
                return "";
            }

            string prefix = strings[0];

            for (int i = 1; i < strings.Length; i++) {
                while (strings[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") {
                    return "";
                }
                }
            }

            return prefix;
        }
    }
}