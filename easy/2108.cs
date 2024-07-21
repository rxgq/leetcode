namespace leetcode.easy;

public partial class Solution
{
    public string FirstPalindrome(string[] words)
    {
        foreach (string word in words)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word == reversed) return word;
        }

        return "";
    }
}
