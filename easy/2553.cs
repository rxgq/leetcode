namespace leetcode.easy;

public partial class Solution {
    public int[] SeparateDigits(int[] nums) {
        var ans = new List<int>();

        foreach (int num in nums) {
            
            foreach (char c in num.ToString())
                ans.Add(c - '0');
        }

        return ans.ToArray();
    }
}