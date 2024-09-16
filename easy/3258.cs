namespace leetcode.easy;

public partial class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            int ones = 0;
            int zeroes = 0; 

            for (int j = i; j < s.Length; j++) {
                if (s[j] == '1') ones++;
                if (s[j] == '0') zeroes++;

                if (ones <= k || zeroes <= k) count++;
                else break;
            }
        }

        return count;
    }
}