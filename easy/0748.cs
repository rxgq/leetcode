namespace leetcode.easy;

public partial class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        var charCount = new Dictionary<char, int>();
        foreach(char c in licensePlate) {
            if (char.IsLetter(c)) {
                char lowerChar = char.ToLower(c);

                if (charCount.ContainsKey(lowerChar))
                    charCount[lowerChar]++;
                else 
                    charCount[lowerChar] = 1;
            }
        }
        
        string shortest = null;
        foreach (string word in words) {
            if (IsComplete(word, charCount)) {
                if (shortest == null || word.Length < shortest.Length)
                    shortest = word;
            }
        }

        return shortest;
    }

    public bool IsComplete(string word, Dictionary<char, int> charCount) {
        var wordCharCount = new Dictionary<char, int>();
        foreach (char c in word) {
            char lowerChar = char.ToLower(c);

            if (wordCharCount.ContainsKey(lowerChar))
                wordCharCount[lowerChar]++;

            else
                wordCharCount[lowerChar] = 1;
        }

        foreach (var kvp in charCount) {
            if (!wordCharCount.ContainsKey(kvp.Key) || wordCharCount[kvp.Key] < kvp.Value)
                return false;
        }

        return true;
    }
}
