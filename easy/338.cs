namespace leetcode.easy;

public partial class Solution {
    public int[] CountBits(int n) {
        var ans = new int[n + 1];

        for (int i = 0; i <= n; i++) {
            int count = 0;
            
            int num = i;
            while (num != 0) {
                num &= (num - 1);
                count++;
            }
            ans[i] = count;
        }

        return ans;
    }
}