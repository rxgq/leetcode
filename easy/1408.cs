namespace leetcode.easy;

public partial class Solution {
    public IList<string> StringMatching(string[] words) {
      List<string> result = new();

      for (int i = 0; i < words.Length; i++) {
        for (int j = 0; j < words.Length; j++) {
          if (words[j].Contains(words[i]) && i != j) {
            result.Add(words[i]);
            break;
          }
        }
      }

      return result;
    }
}