namespace leetcode.easy;

public partial class Solution {
    public string MakeSmallestPalindrome(string s) {
        char[] sArr = s.ToArray();

        int l = 0; int r = s.Length - 1;
        while (l < r) {
          if (sArr[l] > sArr[r])
            sArr[l] = sArr[r];
          else sArr[r] = sArr[l];

          l++; r--;
        }

        return new string(sArr);
    }
}