namespace leetcode.easy;

public partial class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > max)
                max = sum;
        }

        return max;
    }
}
