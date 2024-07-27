namespace leetcode.easy;

public partial class Solution {
    public void MoveZeroes(int[] nums) {
        int l = 0;
        
        for (int i = 0; i < nums.Length; i++) {
          if (nums[i] != 0) {
            var temp = nums[i];
            nums[i] = nums[l];
            nums[l] = temp;

            l++;
          }
        }
    }
}