namespace leetcode.easy;

public partial class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        var arrMap = new Dictionary<int, int>();
        var targetMap = new Dictionary<int, int>();
    
        foreach (var num in arr) {
          if (!arrMap.ContainsKey(num)) arrMap[num] = 1;
          else arrMap[num]++;
        }

        foreach (var num in target) {
          if (!targetMap.ContainsKey(num)) targetMap[num] = 1;
          else targetMap[num]++;
        }

        foreach (var kvp in targetMap)
          if (arrMap.ContainsKey(kvp.Key)) {
            if (arrMap[kvp.Key] != targetMap[kvp.Key]) return false;
          } else return false;

        return true;
    }
}