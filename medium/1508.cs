namespace leetcode.medium;

public partial class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        const int MOD = 1000000007;
        var subs = new List<int>();

        for (int i = 0; i < n; i++) {
          int sum = 0;

          for (int j = i; j < n; j++) {
            sum += nums[j];
            subs.Add(sum);
          }
        }

        var subArrays = subs.ToArray();
        Array.Sort(subArrays);
        
        int total = 0;
        for (int i = left - 1; i <= right - 1; i++)
          total = (total + subArrays[i]) % MOD;

        return total;
    }
}