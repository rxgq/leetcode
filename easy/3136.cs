namespace leetcode.easy;

public partial class Solution {
    public bool IsValid(string word) {
        if (word.Length < 3) return false;

        bool hasVowel = false;
        bool hasConsonent = false;

        foreach (char c in word) {
            if (!char.IsLetterOrDigit(c)) return false;

            if ("aeiouAEIOU".Contains(c)) hasVowel = true;
            if (!"aeiouAEIOU".Contains(c) && char.IsLetter(c)) hasConsonent = true;
        }

        return hasVowel && hasConsonent;
    }
}