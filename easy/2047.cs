namespace leetcode.easy;

public partial class Solution {
    public int CountValidWords(string sentence) {
        var words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (string word in words)
            if (IsValidWord(word)) count++;
            
        return count;
    }

    private bool IsValidWord(string word) {
        int hyphens = 0;

        for (int i = 0; i < word.Length; i++) {
            char c =word[i];

            if (char.IsDigit(c)) return false;

            if (c == '-') {
                if (hyphens > 0 || i == 0 || i == word.Length - 1) return false;
                
                if (!char.IsLetter(word[i - 1]) || !char.IsLetter(word[i + 1]))
                    return false;
                
                hyphens++;
            }

            if ((c == '!' || c== ',' || c == '.') && i != word.Length - 1) return false;
        }

        return true;
    }
}