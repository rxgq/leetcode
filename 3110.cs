namespace leetcode;

public partial class Solution
{
    public int ScoreOfString(string s)
    {
        int total = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            total += Math.Abs(s[i] - s[i + 1]);
        }

        return total;
    }
}
