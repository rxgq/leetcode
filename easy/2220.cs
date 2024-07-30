namespace leetcode.easy;

public partial class Solution {
    public int MinBitFlips(int start, int goal) {
        int result = start ^ goal;
        int flips = 0;

        while (result != 0) { 
          flips += result & 1;
          result >>= 1;
        }

        return flips;
    }
}