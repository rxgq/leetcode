namespace leetcode.easy;

public partial class Solution {
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);

        var averages = new List<double>();

        int left = 0; int right = nums.Length - 1;
        for (int i = 0; i < nums.Length / 2; i++) {
            double average = ((double)nums[left] + (double)nums[right]) / 2;
            averages.Add(average);

            left++; right--;
        }

        return averages.ToArray().Min();
    }
}