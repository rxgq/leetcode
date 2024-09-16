namespace leetcode.easy;

public partial class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
        var stables = new List<int>();

        for (int i = 1; i < height.Length; i++)
            if (height[i - 1] > threshold) stables.Add(i);

        return stables.ToArray();
    }
}