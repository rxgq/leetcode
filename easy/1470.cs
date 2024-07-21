namespace leetcode.easy;

public partial class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] x = new int[n * 2];

        for (int i = 0; i < n; i++)
        {
            x[2 * i] = nums[i];
            x[2 * i + 1] = nums[i + n];
        }

        return x;
    }
}
