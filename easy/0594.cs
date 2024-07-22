namespace leetcode.easy;

public partial class Solution
{
    public int FindLHS(int[] nums)
    {
        Array.Sort(nums);

        int left = 0; int right = 1;
        int max = 0;
        while (right < nums.Length)
        {
            if (nums[right] - nums[left] == 1)
            {
                max = Math.Max(max, right - left + 1);
            }
            else if (nums[right] - nums[left] > 1)
            {
                left++;
                continue;
            }

            right++;
        }

        return max;
    }
}
