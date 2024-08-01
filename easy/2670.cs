namespace leetcode.easy;

public partial class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {
        var distinct = new HashSet<int>(nums);
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
          var distinctPrefix = new HashSet<int>(nums[..(i + 1)]);
          var distinctSuffix = new HashSet<int>(nums[(i + 1)..]);

          result[i] = distinctPrefix.Count - distinctSuffix.Count;
        }

        return result;
    }
}