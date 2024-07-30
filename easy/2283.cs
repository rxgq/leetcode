namespace leetcode.easy;

public partial class Solution {
    public bool DigitCount(string num) {
        var freq = new int[10];

        for (int i = 0; i < num.Length; i++)
          freq[num[i] - '0']++;

        for (int i = 0; i < num.Length; i++)
          if (freq[i] != num[i] - '0') return false;

        return true;
    }
}