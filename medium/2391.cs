namespace leetcode.easy;

public partial class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {

      int Collect(char g) {
        int sum = 0;
        int lastIndex = -1;

        for (int i = 0; i < garbage.Length; i++) {
          foreach (char c in garbage[i]) {
            if (c == g) {
              sum++;
              lastIndex = i;
            }
          }
        }

        for (int j = 0; j < lastIndex; j++)
          sum += travel[j];

        return sum;
      }
      
      return Collect('G') + Collect('P') + Collect('M');
    }
}