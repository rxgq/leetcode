namespace leetcode.easy;

public class Solution {
    public int AverageValue(int[] nums) {
        int count = 0;
        int sum = 0;

        foreach (int num in nums) {
          if (num % 6 == 0) {
           count++;
           sum += num; 
          }
        }
        
        if (sum != 0 && count != 0) return sum / count;
        return 0;
    }
}