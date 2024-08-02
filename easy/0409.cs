namespace leetcode.easy;

public partial class Solution {
    public int LongestPalindrome(string s) {
        var letters = new int[128];

        foreach (char c in s)
            letters[c]++;

        int ans = 0;
        foreach (var letter in letters) {
            ans += (letter / 2) * 2;
            if (ans % 2 == 0 && letter % 2 == 1) ans++;
        }

        return ans;
    }
}