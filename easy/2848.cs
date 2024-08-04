namespace leetcode.easy;

public partial class Solution {
    public int NumberOfPoints(IList<IList<int>> nums) {
        var points = new HashSet<int>();

        foreach(IList<int> car in nums)
            for(int i = car[0]; i <= car[1]; i++)
                points.Add(i);

        return points.Count;
    }
}