namespace leetcode.easy;

public partial class Solution {
    public int SpecialArray(int[] nums) {
        for (int i = 0; i <= nums.Length; i++) {
          int greater = 0;

          foreach (int num in nums)
            if (num >= i) greater++;

          if (greater == i) return i;
        }

        return -1;
    }
}