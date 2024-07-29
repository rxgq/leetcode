namespace leetcode.easy;

public partial class Solution {
    public int MinimumChairs(string s) {
        int max = 0;
        int balance = 0;

        foreach (char c in s) {
            balance += c == 'E' ? 1 : -1;
            max = Math.Max(max, balance);
        }

        return max;
    }
}