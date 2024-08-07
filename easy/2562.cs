namespace leetcode.easy;

public partial class Solution {
    public long FindTheArrayConcVal(int[] nums) {
        long sum = 0;

        int l = 0; int r = nums.Length - 1;
        while (l <= r) {
            if (l == r) sum += nums[l];
            else sum += int.Parse(nums[l].ToString() + nums[r].ToString());
            l++; r--;
        }

        return sum;
    }
}