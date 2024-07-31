namespace leetcode.easy;

public partial class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var distinct1 = new List<int>();
        var distinct2 = new List<int>();

        foreach (int num in nums1) {
            if (!nums2.Contains(num) && !distinct1.Contains(num))
                distinct1.Add(num);
        }

        foreach (int num in nums2) {
            if (!nums1.Contains(num) && !distinct2.Contains(num))
                distinct2.Add(num);
        }

        var result = new List<IList<int>> { distinct1, distinct2 };
        return result;
    }
}