namespace leetcode.easy;

public partial class Solution {
    public bool LemonadeChange(int[] bills) {
        var fives = 0; var tens = 0;
        
        for (int i = 0; i < bills.Length; i++) {
          if (bills[i] == 5) fives++;
          else if (bills[i] == 10) {
            if (fives > 0) {
               fives--; tens++;
            }
            else return false;
          }
          else {
            if (fives > 0 && tens > 0) {
              fives--; tens--;
            }
            else if (fives > 2) {
              fives -= 3;
            } else return false;
          }
        }

        return true;
    }
}