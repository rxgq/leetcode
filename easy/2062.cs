namespace leetcode.easy;

public partial class Solution {
    public int CountVowelSubstrings(string word) {
        HashSet<char> vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u' };
        int count = 0;

        for (int i = 0; i < word.Length; i++) {
            if (!vowels.Contains(word[i]))
                continue;

            HashSet<char> seenVowels = new HashSet<char>();

            for (int j = i; j < word.Length; j++) {
                if (vowels.Contains(word[j])) {
                    seenVowels.Add(word[j]);

                    if (seenVowels.Count == 5) 
                        count++;
                } else break;
            }
        }
        
        return count;
    }
}
