namespace leetcode.easy;

public partial class Solution {
    public bool XorGame(int[] nums) {
        int xor = 0;
        foreach (int n in nums)
          xor ^= n;

        return xor == 0 || nums.Length % 2 == 0;
    }
}