namespace leetcode.easy;

public partial class Solution {
    public int CountElements(int[] nums) {
      int max = nums.Max();
      int min = nums.Min();

      int count = 0;
      for(int i = 0; i < nums.Length; ++i) {
          if(nums[i] < max && nums[i] > min)
              count++;
      }

      return count;
    }
}