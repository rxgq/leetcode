namespace leetcode.easy;

public partial class Solution {
    public int MinimumPushes(string word) {
      var chars = new Dictionary<char, int>();

      foreach (char c in word)
        chars[c] = chars.TryGetValue(c, out int val) ? ++val : 1;

      var frequencies = chars.Values.OrderByDescending(f => f).ToList();

      int buttonCount = 1;
      int count = 0;
      int charCount = 0;

      foreach (var kvp in frequencies) {
        count += buttonCount * kvp;
        charCount++;

        if (charCount % 8 == 0) buttonCount++;
      }

      return count;
    }
}