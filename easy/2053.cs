namespace leetcode.easy;

public partial class Solution {
    public string KthDistinct(string[] arr, int k) {
        var seen = new HashSet<string>();
        var unique = new List<string>();

        for (int i = 0; i < arr.Length; i++) {
          if (seen.Contains(arr[i])) {
            unique.Remove(arr[i]);
          } else {
            unique.Add(arr[i]);
            seen.Add(arr[i]);
          }
        }
        
        if (k - 1 < unique.Count) 
          return unique[k - 1];
        
        return "";
    }
}