namespace leetcode.easy;

public partial class Solution {
    public bool DivideArray(int[] nums) {
        int n = nums.Length / 2;

        var numsDict = new Dictionary<int, int>();
        foreach (var num in nums)
            numsDict[num] = numsDict.TryGetValue(num, out var val) ? ++val : 1;

        foreach (var kvp in numsDict)
            if (kvp.Value % 2 != 0) return false;

        return true;
    }
}