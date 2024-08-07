namespace leetcode.easy;

public partial class Solution {
    public bool IsMonotonic(int[] nums) {
        bool up = true;
        bool down = true;

        for (int i = 0; i < nums.Length - 1; i++) {
          if (nums[i] < nums[i + 1]) up = false;
          else if (nums[i] > nums[i + 1]) down = false;
        }

        return up || down;
    }
}