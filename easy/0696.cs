namespace leetcode.easy;

public partial class Solution {
    public int CountBinarySubstrings(string s) {
        int sum = 0;
        int curr = 1;
        int prev = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1]) curr++;
            else {
                prev = curr;
                curr = 1;
            }

            if (prev >= curr) sum++;
        }
        
        return sum;
    }
}