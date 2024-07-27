namespace leetcode.easy;

public partial class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var occurences = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++) {
          if (occurences.ContainsKey(arr[i])) occurences[arr[i]] += 1;
          else occurences[arr[i]] = 1;
        }

        var unique = new HashSet<int>();
        foreach (var val in occurences.Values)
          if (!unique.Add(val)) return false;

        return true;
    }
}