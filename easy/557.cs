namespace leetcode.easy;

public partial class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(" ");
        string[] reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            reversedWords[i] = new string(chars);
        }

        return string.Join(" ", reversedWords);
    }
}
