namespace leetcode.easy;

public partial class Solution
{
    public int PivotInteger(int n)
    {
        int totalSum = n * (n + 1) / 2;

        for (int x = 1; x <= n; x++)
        {
            int sum1ToX = x * (x + 1) / 2;
            int sumXToN = totalSum - (x - 1) * x / 2;

            if (sum1ToX == sumXToN) return x;
        }

        return -1;
    }
}
