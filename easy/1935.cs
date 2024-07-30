namespace leetcode.easy;

public partial class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        string[] words = text.Split(" ");

        int invalid = 0;
        foreach (string s in words) {
            foreach (char c in s) {
                if (brokenLetters.Contains(c)) {
                    invalid++;
                    break;
                }
            }
        }

        return words.Length - invalid;
    }
}