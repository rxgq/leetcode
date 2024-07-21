namespace leetcode.easy;

public partial class Solution
{
    public int MaxDepth(string s)
    {
        int max = 0;
        int depth = 0;

        foreach (char c in s)
        {
            if (c == '(') max = Math.Max(max, ++depth);
            if (c == ')') depth--;
        }

        return max;
    }
}
