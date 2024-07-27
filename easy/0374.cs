namespace leetcode.easy;

public partial class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1; int h = n;

        while (l <= h) {
          var mid = l + (h - l) / 2;
          var result = guess(mid);

          if (result == 0) return mid;
          else if (result == -1) h = mid - 1;
          else l = mid + 1;

        }

        return -1;
    }
}