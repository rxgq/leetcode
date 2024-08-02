namespace leetcode.easy;

public partial class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int boundary = 0;
        
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            boundary += nums[i];

            if (boundary == 0) count++;
        }

        return count;
    }
}