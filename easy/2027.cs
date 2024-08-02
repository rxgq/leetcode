namespace leetcode.easy;

public partial class Solution {
    public int MinimumMoves(string s) {
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] != 'O') {
                i += 2;
                count++;
            }
        }

        return count;
    }
}