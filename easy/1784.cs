namespace leetcode.easy;

public partial class Solution {
    public bool CheckOnesSegment(string s) {
        int count = 0;
        for (int i = 1; i < s.Length; i++) {
            if (i == 1 && s[i - 1] == '1') count++;
            if (s[i] == '1' && s[i - 1] != '1') count++;
        }

        return count < 2;
    }
}