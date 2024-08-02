namespace leetcode.easy;

public partial class Solution {
    public bool IsArraySpecial(int[] nums) {
        if (nums.Length == 1) return true;
        
        for (int i = 1; i < nums.Length; i++) {
            var p = nums[i - 1] % 2 == 0;
            var c = nums[i] % 2 == 0;

            if (!(!p && c || p && !c)) return false;
        }

        return true;
    }
}