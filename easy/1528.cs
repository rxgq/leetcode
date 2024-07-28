namespace leetcode.easy;

public partial class Solution {
    public string RestoreString(string s, int[] indices) {
      char[] result = new char[s.Length];

      for (int i = 0; i < s.Length; i++)
        result[indices[i]] = s[i]; 

      return new string(result);
    }
}