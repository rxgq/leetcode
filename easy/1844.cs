namespace leetcode.easy;

public partial class Solution {
    public string ReplaceDigits(string s) {
        string ans = "";

        for (int i = 0; i < s.Length; i++) {
            if (char.IsDigit(s[i])) {
                ans += shift((char)s[i - 1], s[i] - '0');
            } else {
                ans += s[i];
            }
        }

        return ans;
    }

    public char shift(char c, int x) 
        => (char)(c + x);
}