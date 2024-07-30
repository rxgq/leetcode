namespace leetcode.easy;

public partial class Solution {
    public bool HalvesAreAlike(string s) {
        string vowels = "aeiouAEIOU";

        int aCount = 0;
        int bCount = 0;

        string s1 = s[..(s.Length / 2)];
        string s2 = s.Substring(s.Length / 2, s.Length / 2);

        for (int i = 0; i < s.Length / 2; i++) {
            if (vowels.Contains(s1[i])) aCount++;
            if (vowels.Contains(s2[i])) bCount++;
        }

        return aCount == bCount;
    }
}