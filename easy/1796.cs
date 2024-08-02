namespace leetcode.easy;

public partial class Solution {
    public int SecondHighest(string s) {
        int second = -1;

        var digits = new SortedSet<int>();

        foreach (char c in s) {
            if (char.IsDigit(c))
                digits.Add(c - '0');
        }

        if (digits.Count > 1) {
            int count = 0;
            foreach (int num in digits) {
                if (count == digits.Count - 2) second = num;
                count++;
            }
        }

        return second;
    }
}