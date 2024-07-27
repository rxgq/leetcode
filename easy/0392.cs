namespace leetcode.easy;

public partial class Solution {
    public bool IsSubsequence(string s, string t) {
      int sP = 0; int tP = 0;

      while (tP < t.Length) {
        if (sP < s.Length && t[tP] == s[sP]) {
          sP++;
        }

        tP++;
      }

      return sP == s.Length;
    }
}