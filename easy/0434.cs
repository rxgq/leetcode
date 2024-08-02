namespace leetcode.easy;

public partial class Solution {
    public int CountSegments(string s) {
        int count = 0;
        bool isSpace = false;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] != ' ') {
                if (!isSpace) {
                    count++;
                    isSpace = true;
                }
            } else {
                isSpace = false;
            }
        }

        return count;
    }
}