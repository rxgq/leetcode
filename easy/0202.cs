namespace leetcode.easy;

public partial class Solution {
    public bool IsHappy(int n) {

        int SumOfSquares(int number) {
            int sum = 0;
            while (number > 0) {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }

        var seen = new HashSet<int>();
        while (n != 1 && !seen.Contains(n)) {
            seen.Add(n);
            n = SumOfSquares(n);
        }

        return n == 1;
    }
}