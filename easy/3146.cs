namespace leetcode.easy;

public partial class Solution
{
    public int FindPermutationDifference(string s, string t)
    {
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char x = s[i];
            sum += Math.Abs((i - t.IndexOf(x)));
        }

        return sum;
    }
}
