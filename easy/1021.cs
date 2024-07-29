namespace leetcode.easy;

public partial class Solution {
    public string RemoveOuterParentheses(string s) {
        string ans = "";
        int balance = 0;

        foreach (char c in s) {
            if (c == '(') {
                balance++;
                if (balance > 1) ans += c;
            } else {
                balance--;
                if (balance > 0) ans += c;
            }
        }

        return ans;
    }
}