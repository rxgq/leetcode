namespace leetcode.easy;

public partial class Solution {
    public int[] FairCandySwap(int[] alices, int[] bobs) {
        var target = (alices.Sum() - bobs.Sum()) / 2;
        
        foreach (int a in alices) {
          int b = a - target;

          if (bobs.Contains(b)) 
            return new int[] { a, b };
        }

        return new int[0];
    }
}