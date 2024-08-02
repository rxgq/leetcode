namespace leetcode.easy;

public partial class Solution {
    public int NumberOfSpecialChars(string word) {
        int count = 0;

        var characters = new HashSet<char>(word);

        foreach (char c in word) {
            char lower = char.ToLower(c);
            char upper = char.ToUpper(c);

            if (characters.Contains(char.ToLower(c)) && characters.Contains(char.ToUpper(c))) {
                count++;
                characters.Remove(lower);
                characters.Remove(upper);
            }
        } 

        return count;
    }
}