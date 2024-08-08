namespace leetcode.easy;

public partial class Solution {
    public string ClearDigits(string s) {
        var ans = new List<char>();

        foreach (char c in s) {
          if (char.IsDigit(c))  ans.RemoveAt(ans.Count - 1);
          else ans.Add(c);
        }

        return new string(ans.ToArray());
    }
}