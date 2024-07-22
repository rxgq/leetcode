namespace leetcode.easy;

public partial class Solution
{
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int x = nums2[0] - nums1[0];
        return x;
    }
}
