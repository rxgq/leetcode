namespace leetcode.medium;

public partial class Solution {
    public string ReverseWords(string s) {
        string reversed = "";
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
          var temp = words[l];
          words[l] = words[r];
          words[r] = temp;

          l++; r--;
        }

        return string.Join(" ", words);
    }
}