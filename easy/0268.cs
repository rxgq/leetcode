namespace leetcode.easy;

public partial class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == mid) left = mid + 1;
            else right = mid - 1;
        }

        return left;
    }
}
