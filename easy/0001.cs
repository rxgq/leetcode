namespace leetcode.easy;

public partial class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var pairs = nums.Select((num, index) => (Num: num, Index: index)).ToArray();
        Array.Sort(pairs, (a, b) => a.Num.CompareTo(b.Num));

        int left = 0, right = nums.Length - 1;

        while (left < right) {
            var sum = pairs[left].Num + pairs[right].Num;
            if (sum == target) return [pairs[left].Index, pairs[right].Index];
            if (sum < target) left++;
            else right--;
        }

        return [];
    }
}
