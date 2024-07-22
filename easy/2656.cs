namespace leetcode.easy;

public partial class Solution
{
    public int MaximizeSum(int[] nums, int k)
    {
        Array.Sort(nums);

        int maxElement = nums[nums.Length - 1];
        int score = 0;

        for (int i = 0; i < k; i++)
        {
            score += maxElement;
            maxElement++;
        }

        return score;
    }
}
