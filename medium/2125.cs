namespace leetcode.easy;

public partial class Solution {
    public int NumberOfBeams(string[] bank) {
        int beams = 0;

        int prevCount = CountOnes(bank[0]);
        for (int row = 1; row < bank.Length; row++) {
            var currentCount = CountOnes(bank[row]);

            if (currentCount > 0) {
              beams += (prevCount * currentCount);
              prevCount = currentCount;
            }
        }

        return beams;
    }
    
    public int CountOnes(string str) {
      int count = 0;
      foreach (char c in str) {
        if (c == '1') count++;
      }
      return count;
    }
}