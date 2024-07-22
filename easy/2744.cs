
namespace leetcode.easy;

public partial class Solution
{
    public int MaximumNumberOfStringPairs(string[] words)
    {
        int count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                char[] jArr = words[j].ToCharArray();
                Array.Reverse(jArr);
                string jStr = new string(jArr);

                if (jStr == words[i])
                {
                    count++;
                }
            }
        }

        return count;
    }
}
