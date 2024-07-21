namespace leetcode.easy;

public partial class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        int c = 0;
        for (int i = 0; i < nums.Count; i++)
            for (int j = 0; j < nums.Count; j++)
                if (nums[i] + nums[j] < target && 0 <= i && i < j && j < nums.Count)
                {
                    c++;
                }

        return c;
    }
}
