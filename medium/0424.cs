namespace leetcode.medium;

public partial class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0; int r = 0;
        
        var letters = new Dictionary<char, int>();

        int result = 0;
        while (r < s.Length) {
          if (!letters.ContainsKey(s[r])) letters[s[r]] = 1;
          else letters[s[r]]++;

          while ((r - l + 1) - letters.Values.Max() > k) {
            letters[s[l]]--;
            l++;
          }

          result = Math.Max(result, r - l + 1);
          r++;
        }

        return result;
    }
}