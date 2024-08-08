namespace leetcode.easy;

public partial class Solution
{
    public int MinTimeToType(string word)
    {
        if (string.IsNullOrEmpty(word))
          return 0;

        char prev = 'a';

        int res = 0;
        for (int i = 0; i < word.Length; i++) {
          char curr = word[i];

          var distance = Math.Abs(curr - prev);
          var minDistance = Math.Min(distance, 26 - distance) + 1;

          res += minDistance;
          prev = curr;
        }

        return res;
    }
}
