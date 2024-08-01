namespace leetcode.easy;

public partial class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0;
        int rightSum = 0;

        foreach (int num in nums) 
            rightSum += num; 

        for (int i = 0; i < nums.Length; i++) {
            rightSum -= nums[i];

            if (leftSum == rightSum)
                return i; 
            
            leftSum += nums[i];
        }

        return -1;
    }
}