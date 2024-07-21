using System.Text;

namespace leetcode.easy;

public partial class Solution
{
    public string TruncateSentence(string s, int k)
    {
        string[] words = s.Split(' ');
        var result = new StringBuilder();

        for (int i = 0; i < k; i++)
        {
            result.Append(i == 0 ? "" : " ");
            result.Append(words[i]);
        }

        return result.ToString();
    }
}
