namespace leetcode.easy;

public partial class Solution {
    public string GreatestLetter(string s) {
        var chars = new HashSet<char>();

        foreach (char c in s)
          chars.Add(c);

        int greatest = -1;
        for (int i = 0; i < 26; i++) {
          if (chars.Contains((char)(i + 97)) && chars.Contains((char)(i + 65))) {
            greatest = Math.Max(greatest, i);
          }
        }

        return greatest == -1 ? "" : ((char)(greatest + 97)).ToString().ToUpper();
    }
}