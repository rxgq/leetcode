namespace leetcode.easy;

public partial class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        int count = 0;

        for (int i = 0; i < words.Length; i++) {
          if (isVowel(words[i][0]) && isVowel(words[i][^1])) {
            if (i >= left && i <= right) count++;
          }
        }

        return count;
    }

    public bool isVowel(char c)
      => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}