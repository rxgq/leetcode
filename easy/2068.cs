namespace leetcode.easy;

public partial class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        var chars = new Dictionary<char, int>();

        foreach (char c in word1)
          chars[c] = chars.TryGetValue(c, out int val) ? ++val : 1;

        foreach (char c in word2)
          chars[c] = chars.TryGetValue(c, out int val) ? --val : -1;

        foreach (var val in chars.Values) {
            if (Math.Abs(val) > 3) return false;
        }

        return true;
    }
}