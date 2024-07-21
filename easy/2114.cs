namespace leetcode.easy;

public partial class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int maxCount = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(" ");

            if (words.Length > maxCount)
                maxCount = words.Length;
        }

        return maxCount;
    }
}
