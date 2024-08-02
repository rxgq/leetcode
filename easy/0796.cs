namespace leetcode.easy;

public partial class Solution {
    public bool RotateString(string s, string goal) {
        var chars = s.ToCharArray();

        for (int i = 0; i < s.Length; i++) {

            for (int j = 0; j < s.Length -1; j++) {
                var temp = chars[j];
                chars[j] = chars[j + 1];
                chars[j + 1] = temp;
            }

            if (new string(chars) == goal) return true;
        }

        return false;
    }
}