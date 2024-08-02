namespace leetcode.easy;

public partial class Solution {
    public bool IsPrefixString(string s, string[] words) {
        string concat = "";
        
        for (int i = 0; i < words.Length; i++) {
            concat += words[i];

            if (concat == s) return true;
        }

        return false;
    }
}