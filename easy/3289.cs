namespace leetcode.easy;

public partial class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int, int> sneaky = new Dictionary<int, int>();
        List<int> result = new List<int>();
        foreach (var num in nums) {
            if (!sneaky.TryAdd(num, 1)) {
                if(!result.Contains(num)) result.Add(num);
                sneaky[num]++;
            }
        }

        return result.ToArray();
    }
}