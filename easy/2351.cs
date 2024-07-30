namespace leetcode.easy;

public partial class Solution {
    public char RepeatedCharacter(string s) {
        var letters = new HashSet<char>();

        foreach (char c in s)
            if (!letters.Add(c)) return c;

        return ' ';
    }
}