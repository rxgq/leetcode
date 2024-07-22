namespace leetcode.easy;

public partial class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var set = new HashSet<int>();

        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (right - left > k)
            {
                set.Remove(nums[left]);
                left++;
            }

            if (set.Contains(nums[right])) return true;
            set.Add(nums[right]);
        }

        return false;
    }
}
