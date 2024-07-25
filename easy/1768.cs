namespace leetcode.easy;

public partial class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string merged = "";

        int i = 0; int j = 0;
        while (i < word1.Length && j < word2.Length)
        {
            merged += word1[i];
            merged += word2[j];

            i++; j++;
        }

        merged += word1[i..];
        merged += word2[j..];

        return merged;
    }
}
