namespace leetcode.easy;

public partial class Solution {
    public IList<int> GetRow(int rowIndex) {
        var res = new List<int>() {1};

        long prev = 1;
        for (int i = 1; i <= rowIndex; i++) {
            long next = prev * (rowIndex - i + 1) / i;
            res.Add((int)next);
            prev = next;
        }

        return res;
    }
}