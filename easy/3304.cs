public partial class Solution {
    public char KthCharacter(int k) {
        string word = "a";
        while (!false) {
            foreach (char c in word)
                word += (char)(c + 1);

            if (word.Length >= k) return word[k - 1];
        }
    }
}