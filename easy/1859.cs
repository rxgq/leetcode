namespace leetcode.easy;

public partial class Solution
{
    public string SortSentence(string s)
    {
        string[] words = s.Split(" ");
        string[] sortedWords = new string[words.Length];

        foreach (string word in words)
        {
            int index = word[word.Length - 1] - '0';
            string w = word.Substring(0, word.Length - 1);
            sortedWords[index - 1] = w;
        }

        return string.Join(" ", sortedWords);
    }
}
