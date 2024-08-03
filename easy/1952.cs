namespace leetcode.easy;

public class Solution {
    public bool IsThree(int n) {
        int divisors = 0;

        for (int i = 1; i <= n; i++)
          if (n % i == 0) divisors++;

        return divisors == 3;
    }
}