namespace leetcode.easy;

public partial class Solution {
    public string[] FindWords(string[] words) {
          List<string> ans = new();

          var row1 = new HashSet<char>() {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'}; 
          var row2 = new HashSet<char>() {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'}; 
          var row3 = new HashSet<char>() {'z', 'x', 'c', 'v', 'b', 'n' ,'m'}; 
          
          foreach (string word in words) {
            var letters = word.ToLower().ToHashSet();

            if (letters.IsSubsetOf(row1) || letters.IsSubsetOf(row2) || letters.IsSubsetOf(row3)) {
              ans.Add(word);
            }
          }

          return ans.ToArray();
    }
}