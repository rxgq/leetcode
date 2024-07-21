namespace leetcode.easy;

public partial class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        Array.Reverse(nums);

        int count = 0;
        foreach (int i in nums)
            if (i < k)
                count++;

        return count;
    }
}
