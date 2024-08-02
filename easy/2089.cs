namespace leetcode.easy;

public partial class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);

        var indices = new List<int>();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == target) indices.Add(i);

        return indices;
    }
}