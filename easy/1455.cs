namespace leetcode.easy;

public partial class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
            if (words[i].IndexOf(searchWord) == 0) return i + 1;

        return -1;
    }
}