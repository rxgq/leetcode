namespace leetcode.easy;

public partial class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int ops = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] % 3 != 0) ops++;

        return ops;
    }
}
