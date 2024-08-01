namespace leetcode.easy;
public partial class Solution {
    public int TotalMoney(int n) {
        int total = 0;

        int week = 0;
        for (int i = 0; i <= n; i++) {
          total += (i + week);
          
          if (i != 0 && i % 7 == 0) 
            week += -6;
        }

        return total;
    }
}