namespace leetcode.easy;

public partial class Solution {
    public int CountCharacters(string[] words, string chars) {
        int goodSum = 0;

        foreach (string word in words) {
          string charStr = chars;

          bool isGood = true;
          foreach (char c in word) {
            var idx = charStr.IndexOf(c);
            if (idx != -1) {
              charStr = charStr.Remove(idx, 1);
            }
            else {
              isGood = false;
              break;
            }
          }

          if (isGood) goodSum += word.Length;
        }

        return goodSum;
    }
}