namespace leetcode.easy;

public partial class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0; int r = s.Length - 1;
        while (l < r) {
            if (s[l] != s[r]) {
                return IsPalindrome2(s.Substring(l + 1, r - l)) || IsPalindrome2(s.Substring(l, r - l));
            }

            l++; r--;
        }

        return true;
    }

    private bool IsPalindrome2(string s) {
        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[s.Length - i - 1]) return false;

        return true;
    }
}