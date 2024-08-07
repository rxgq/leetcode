namespace leetcode.medium;

public partial class Solution {
    public int MaxVowels(string s, int k) {
        int maxVowels = 0;
        int currentVowels = 0;

        for (int i = 0; i < k; i++)
            if ("aeiouAEIOU".Contains(s[i]))
            currentVowels++;

        maxVowels = currentVowels;

        for (int i = k; i < s.Length; i++) {
            if ("aeiouAEIOU".Contains(s[i - k])) 
                currentVowels--;

            if ("aeiouAEIOU".Contains(s[i])) 
                currentVowels++;

            maxVowels = Math.Max(maxVowels, currentVowels);
        }

        return maxVowels;
    }
}