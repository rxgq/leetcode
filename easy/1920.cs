namespace leetcode.easy;

public partial class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] ns = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            ns[i] = nums[nums[i]];
        }

        return ns;
    }
}
