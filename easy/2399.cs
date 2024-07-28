namespace leetcode.easy;

public partial class Solution {
    public bool CheckDistances(string s, int[] distance) {
      int[] firstOccurences = new int[26];
      Array.Fill(firstOccurences, -1);

      for (int i = 0; i < s.Length; i++) {
        var c = s[i] - 'a';

        if (firstOccurences[c] == -1) {
          firstOccurences[c] = i;
        } else {
          int actualDistance = i - firstOccurences[c] - 1;
          if (actualDistance != distance[c]) {
            return false;
          }
        }
      }

      return true;
    }
}