namespace leetcode.easy;

public partial class Solution {
    public int CountPrefixes(string[] words, string s) {
        int count = 0;

        foreach (var word in words) {
          if (word.Length <= s.Length) {
            var prefix = s[0..word.Length];

            if (prefix == word) 
              count++;
          }
          
        } 

        return count;
    }
}