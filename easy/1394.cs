namespace leetcode.easy;

public partial class Solution {
    public int FindLucky(int[] arr) {
        var nums = new Dictionary<int, int>();
        foreach (int num in arr)
          nums[num] = nums.TryGetValue(num, out int val) ? ++val : 1;

        int largest = -1;
        foreach (var kvp in nums)
          if (kvp.Key == kvp.Value) largest = Math.Max(largest, kvp.Key);

        return largest;
    }
}