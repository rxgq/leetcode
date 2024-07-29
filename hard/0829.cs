namespace leetcode.hard;

public partial class Solution {
    public int ConsecutiveNumbersSum(int n) {
        int sum = 0;
        int k = 1;
        
        // a, a+1, a+2, a+3, ..., a+(k-1)
        //
        // k = 1,   a = 15  (a = 15)    valid
        // k = 2:   2a + 1  (a = 7)     valid
        // k = 3:   3a + 3  (a = 4)     valid
        // k = 4:   4a + 6  (a = 2.25)  invalid
        // k = 5:  5a + 10  (a = 1)     valid
        while (k * (k - 1) / 2 < n) {
            int kSum = k * (k - 1) / 2; // 0, 1, 3, 6, 10

            if ((n - kSum) % k == 0) {
                int a = (n - kSum) / k;

                if (a > 0) sum++;
            }

            k++;
        }

        return sum;
    }
}