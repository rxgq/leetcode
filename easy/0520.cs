namespace leetcode.easy;

public partial class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length == 1) return true;

        var capitalCount = 0;
        for (int i = 0; i < word.Length; i++) 
            if (char.IsUpper(word[i])) capitalCount++;

        if (capitalCount == 1 && char.IsUpper(word[0])) return true;
        return capitalCount == word.Length || capitalCount == 0;
    }
}