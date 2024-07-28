namespace leetcode.easy;

public partial class Solution {
    public int[] DiStringMatch(string s) {
        var ans = new int[s.Length + 1];

        int high = s.Length;
        int low = 0;

        for (int i = 0; i < s.Length; i++) {
          if (s[i] == 'I') {
            ans[i] = low;
            low++;
          } else {
            ans[i] = high;
            high--;
          }
        }

        ans[s.Length] = high;

        return ans;
    }
}