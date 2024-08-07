namespace leetcode.medium;

public partial class Solution {
    public string ReverseWords(string s) {
        int start = 0;
        
        List<string> words = new();
        for (int i = 0; i < s.Length; i++) {
          if (s[i] == ' ') {
            if (i > start) {
              words.Add(s.Substring(start, i - start));
            }

            start = i + 1;
          }
        }

        if (start < s.Length)
            words.Add(s.Substring(start));
        
        int l = 0; 
        int r = words.Count - 1;
        while (l < r) {
            (words[r], words[l]) = (words[l], words[r]);
            l++; r--;
        }

        return string.Join(" ", words);
    }
}