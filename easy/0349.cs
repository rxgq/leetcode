namespace leetcode.easy;

public partial class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set = new HashSet<int>(nums1);
        var result = new List<int>();

        foreach (var num in nums2) {
          if (set.Contains(num)) {
            result.Add(num);
            set.Remove(num);
          }
        }

        return result.ToArray();
    }
}