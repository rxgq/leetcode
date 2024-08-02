namespace leetcode.easy;

public partial class Solution {
    public int MaxPower(string s) {
        int max = 1;
        int current = 1;

        for (int i = 1; i < s.Length; i++) {
            if (s[i] == s[i - 1]) max = Math.Max(max, ++current);
            else current = 1;
        }

        return max;
    }
}