namespace leetcode.easy;

public partial class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var set3 = new HashSet<int>(nums3);

        var result = new HashSet<int>();

        foreach (int num in set1) {
          if (set2.Contains(num) || set3.Contains(num))
            result.Add(num);
        }

        foreach (int num in set2)
          if (set3.Contains(num)) result.Add(num);

        return result.ToList();
    }
}