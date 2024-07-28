namespace leetcode.easy;

public partial class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> splitWords = new();
        
        for (int w = 0; w < words.Count; w++) {
          List<string> split = new();

          int start = 0;
          for (int i = 0; i < words[w].Length; i++) {
            if (words[w][i] == separator) {
              split.Add(words[w][start..(i)]);
              start = i + 1;
            }
          }

          split.Add(words[w][start..]);

          for (int j = 0; j < split.Count; j++) 
            if (split[j] != "") splitWords.Add(split[j]);
        }

        return splitWords;
    }
}