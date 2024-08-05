namespace leetcode.easy;

public class Solution {
    public int ThirdMax(int[] nums) {
        var distinct = new List<int>();

        foreach (int num in nums)
          if (!distinct.Contains(num)) distinct.Add(num);

        distinct.Sort();
        if (distinct.Count > 2) return distinct[distinct.Count - 3];

        return distinct.Max();
    }
}