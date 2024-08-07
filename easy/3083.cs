namespace leetcode.easy;

public partial class Solution {
    public bool IsSubstringPresent(string s) {
        var substrs = new List<string>();

        for (int i = 0; i < s.Length - 1; i++)
            substrs.Add(s.Substring(i, 2));

        foreach (string str in substrs) {
            string reversed = str[1].ToString() + str[0].ToString();
            if (s.Contains(reversed)) return true;
        }

        return false;
    }
}