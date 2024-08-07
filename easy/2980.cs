namespace leetcode.easy;

public partial class Solution {
    public bool HasTrailingZeros(int[] nums) {
        int count = 0;
        foreach (int num in nums) 
            if (num % 2 == 0) count++;
        
        return count > 1;
    }
}