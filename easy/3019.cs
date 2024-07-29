namespace leetcode.easy;

public partial class Solution {
    public int CountKeyChanges(string s) {
        int count = 0;

        for (int i = 1; i < s.Length; i++) {
            if (char.ToLower(s[i - 1]) != char.ToLower(s[i]))
                count++;
        }

        return count;
    }
}