namespace leetcode.easy;

public partial class Solution {
    public int[] SumZero(int n) {
        var nums = new List<int>();        

        for (int i = 1; i < n / 2 + 1; i++) {
            nums.Add(i);
            nums.Add(-i);
        }

        if (n % 2 != 0) nums.Add(0);

        return nums.ToArray();
    }
}