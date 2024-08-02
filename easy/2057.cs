namespace leetcode.easy;

public partial class Solution {
    public int SmallestEqual(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (i % 10 == nums[i])
                return i;
        }

        return -1;
    }
}