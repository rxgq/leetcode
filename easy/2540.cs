namespace leetcode.easy;

public partial class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        var set = new HashSet<int>(nums1);

        foreach (int num in nums2)
          if (set.Contains(num)) return num;

        return -1;
    }
}