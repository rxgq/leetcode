namespace leetcode.easy;

public partial class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
      var words = text.Split(' ');

      var ans = new List<string>();
      for (int i = 2; i < words.Length; i++) {
        if (words[i - 2] == first && words[i - 1] == second)
          ans.Add(words[i]);
      } 

      return ans.ToArray();
    }
}