namespace leetcode.easy;

public partial class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int x = 0;
        foreach (int num in nums) x |= num;

        return x << (nums.Length - 1);
    }
}
