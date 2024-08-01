namespace leetcode.easy;

public partial class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++) {
            int temp = 0;

            for (int j = i; j < arr.Length; j++) {
                temp += arr[j];

                if (Math.Abs(i - j) % 2 != 0) continue;
                sum += temp;
            }
        }

        return sum;
    }
}