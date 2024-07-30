namespace leetcode.easy;

public partial class Solution {
    public int PercentageLetter(string s, char letter) {
        int count = 0;

        foreach (char c in s)
            if (c == letter) count++;

        return s.Length == 0 ? 0 : (count * 100) / s.Length;
    }
}