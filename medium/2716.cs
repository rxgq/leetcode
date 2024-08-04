namespace leetcode.easy;

public partial class Solution {
    public int MinimizedStringLength(string s) {
        var set = new HashSet<char>();
        foreach (char c in s) set.Add(c);

        return set.Count;
    }
}