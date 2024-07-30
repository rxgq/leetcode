namespace leetcode.easy;

public partial class Solution {
    public string FreqAlphabets(string s) {
        string ans = "";

        for (int i = 0; i < s.Length; i++) {
            if (i + 2 < s.Length && s[i + 2] == '#') {
                string m = s.Substring(i, 2);
                ans += (char)('a' + int.Parse(m) - 1);

                i += 2;
            }
            else ans += (char)('a' + s[i] - '1');
        }

        return ans;
    }
}