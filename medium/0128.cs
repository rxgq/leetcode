namespace leetcode.easy;

public partial class Solution {
    public int LongestConsecutive(int[] nums) {
        var sorted = new HashSet<int>(nums);

        int maxSeq = 0;
        foreach (var num in sorted) {
          if (!sorted.Contains(num - 1)) {
            int curr = num;
            int currSeq = 1;

            while (sorted.Contains(curr + 1)) {
              curr++;
              currSeq++;
            }

            maxSeq = Math.Max(maxSeq, currSeq);
          }
        }
        
        return maxSeq;
    }
}