namespace leetcode.easy;

public partial class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var even = new List<int>();
        var odd = new List<int>();

        foreach (var num in nums) {
            if (num % 2 == 0) even.Add(num);
            else odd.Add(num);
        }

        even.AddRange(odd);
        return even.ToArray();
    }
}