using System;

namespace LeetCodeSolutions
{
    public class LengthOfLastWord {
        public static void Run() {

            // Define an array of strings
            string[] phraseArray = new string[]
            {
            "Hello World",
            "   fly me   to   the moon  ",
            "luffy is still joyboy",
            " a ",
            " ",
            "a"
            };
            for ( int i = 0; i < phraseArray.Length; i++) {
                Console.WriteLine($"The length of the last word in [{String.Join(", ", phraseArray[i])}] is {LastWord(phraseArray[i])}");
            }

        }

        public static int LastWord(string s)
        {
            s = s.Trim();
            int chars = 0;

            for (int i = s.Length - 1; i >= 0; i -= 1) {
                if (s[i] != ' ') {
                chars += 1;
                } else {
                break;
                }
            }
            return chars;
        }
    }
}