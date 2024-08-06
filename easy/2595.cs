namespace leetcode.easy;

public partial class Solution {
    public int[] EvenOddBit(int n) {
        var nBin = Convert.ToString(n, 2);

        int even = 0; int odd = 0;
        for (int i = 0; i < nBin.Length; i++) {
            int bitIndex = nBin.Length - 1 - i;

            if (nBin[bitIndex] == '1') {
                if (i % 2 == 0) even++;
                else odd++;
            }
        }

        return new int[2] { even, odd };
    }
}
