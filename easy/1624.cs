namespace leetcode.easy;

public partial class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        var first = new Dictionary<char, int>();
        var max = -1;

        for (int i = 0; i < s.Length; i++) {
            if (first.ContainsKey(s[i])) max = Math.Max(max, i - first[s[i]] - 1);
            else first[s[i]] = i;
        }

        return max;
    }
}