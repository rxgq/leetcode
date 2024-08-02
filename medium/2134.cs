namespace leetcode.medium;

public partial class Solution {
    public int MinSwaps(int[] nums) {
        int n = nums.Length;

        int totalOnes = 0;
        foreach (var num in nums)
            totalOnes += num;

        int[] extendedArray = new int[2 * n];
        for (int i = 0; i < n; i++) {
            extendedArray[i] = nums[i];
            extendedArray[i + n] = nums[i];
        }

        int currOnes = 0;
        int maxOnes = 0;
        int l = 0;

        for (int r = 0; r < 2 * n; r++) {
            if (extendedArray[r] == 1)
                currOnes++;

            if (r - l + 1 > totalOnes) {
                if (extendedArray[l] == 1)
                    currOnes--;

                l++;
            }

            if (r - l + 1 == totalOnes)
                maxOnes = Math.Max(maxOnes, currOnes);
        }

        return totalOnes - maxOnes;
    }
}
