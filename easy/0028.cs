namespace leetcode.easy;

public partial class Solution {
    public int StrStr(string haystack, string needle) {
        var index = -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            if (haystack.Substring(i, needle.Length) == needle) return i;
        }

        return index;
    }
}