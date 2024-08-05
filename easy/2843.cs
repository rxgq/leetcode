namespace leetcode.easy;

public partial class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count = 0;
        
        for (int i = low; i <= high; i++) {
            string num = i.ToString();
            int n = num.Length;

            if (n % 2 == 1) continue;

            int l = 0; int r = 0;
            for (int j = 0; j < n / 2; j++) {
                l += num[j] - '0';
                r += num[n - 1 - j] - '0';
            }

            if (l == r) count++;
        }

        return count;
    }
}