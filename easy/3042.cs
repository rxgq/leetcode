namespace leetcode.easy;

public partial class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;

        for (int i = 0; i < words.Length; i++) {
          for (int j = i + 1; j < words.Length; j++) {
            if (IsPrefixAndSuffix(words[i], words[j])) {
              count++;
            }
          }
        }

        return count;
    }

    public bool IsPrefixAndSuffix(string str1, string str2) 
      => str2.StartsWith(str1) && str2.EndsWith(str1);
}