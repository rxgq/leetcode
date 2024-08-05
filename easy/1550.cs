namespace leetcode.easy;

public partial class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;
        foreach (int num in arr) {
            count = (num % 2 == 1) ? count + 1 : 0;
            if (count == 3) return true;
        }
        
        return false;
    }
}