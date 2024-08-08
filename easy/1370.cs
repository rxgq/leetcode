namespace leetcode.easy;

public partial class Solution {
    public string SortString(string s) {
      int[] chars = new int[26];
      foreach (char c in s) {
          chars[c - 'a']++;
      }
      
      var result = new StringBuilder();

      int remaining = s.Length;
      while (remaining > 0) {
        for (int i = 0; i < 26; i++) {
          if (chars[i] > 0) {
            result.Append((char)(i + 'a'));
            chars[i]--;
            remaining--;
          }
        }

        for (int i = 25; i >= 0; i--) {
            if (chars[i] > 0) {
                result.Append((char)(i + 'a'));
                chars[i]--;
                remaining--;
            }
        }
      }

      return result.ToString();
    }
}