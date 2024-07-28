namespace leetcode.easy;

public partial class Solution {
    public int MinDeletionSize(string[] strs) {
        int dels = 0;

        for (int i = 0; i < strs[0].Length; i++) {

          for (int j = 1; j < strs.Length; j++) {
            if (strs[j][i] < strs[j - 1][i]) {
              dels++;
              break;
            }
          }
        }

        return dels;
    }
}