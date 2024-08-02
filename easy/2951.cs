namespace leetcode.easy;

public partial class Solution {
    public IList<int> FindPeaks(int[] m) {
        var peaks = new List<int>();

        for (int i = 1; i < m.Length - 1; i++) {
            if (i + 1 > m.Length) continue;
            if (m[i - 1] < m[i] && m[i] > m[i + 1]) peaks.Add(i);
        }

        return peaks.ToArray();
    }
}