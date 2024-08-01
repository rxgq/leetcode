namespace leetcode.easy;

public partial class Solution {
    public char FindTheDifference(string s, string t) {
        var letters = new List<char>(t);

        foreach (char c in s)
            letters.Remove(c);

        return letters[0];
    }
}