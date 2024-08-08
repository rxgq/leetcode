namespace leetcode.easy;

public partial class Solution {
    public int RemovePalindromeSub(string s) {
        if (s.Length == 0) return 0;
        return !IsPalindrome(s) ? 2 : 1;
    }

    private bool IsPalindrome(string s) {
      for (int i = 0; i < s.Length / 2; i++)
        if (s[i] != s[s.Length - i - 1]) return false;

      return true;
    }
}