namespace leetcode.easy;

public partial class Solution {
    public int MinLength(string s) {
        string s2 = s;

        while (s2.Contains("AB") || s2.Contains("CD")) {
            var idx = s2.Contains("AB") ? s2.IndexOf("AB") : s2.IndexOf("CD");
            s2 = s2.Remove(idx, 2);
        }

        return s2.Length;
    }
}