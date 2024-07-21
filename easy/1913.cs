namespace leetcode.easy;

public partial class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;

        int maxProduct = nums[n - 1] * nums[n - 2];
        int minProduct = nums[0] * nums[1];

        return maxProduct - minProduct;
    }
}
