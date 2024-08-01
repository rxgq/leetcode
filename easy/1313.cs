namespace leetcode.easy;
public partial class Solution {
    public int[] DecompressRLElist(int[] nums) {
        var decompressed = new List<int>();

        for (int i = 1; i < nums.Length; i += 2) {

            for (int j = 0; j < nums[i - 1]; j++)
                decompressed.Add(nums[i]);
        }

        return decompressed.ToArray();
    }
}