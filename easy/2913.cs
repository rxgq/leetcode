namespace leetcode.easy;

public partial class Solution {
    public int SumCounts(IList<int> nums) {
        int sum = 0;

        for (int i = 0; i < nums.Count; i++) {
          var dist = new HashSet<int>();

          for (int j = i; j < nums.Count; j++) {
            dist.Add(nums[j]);
            sum += dist.Count * dist.Count;
          }
        }

        return sum;
    }
}