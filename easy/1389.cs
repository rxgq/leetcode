namespace leetcode.easy;

public partial class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        List<int> target = new();

        for (int i = 0; i < nums.Length; i++)
            target.Insert(index[i], nums[i]);

        return target.ToArray();
    }
}
