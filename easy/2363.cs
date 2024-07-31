namespace leetcode.easy;

public partial class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        var freq = new Dictionary<int, int>();

        foreach (var item in items1) {
          var val = item[0]; 
          var weight = item[1];

          if (!freq.ContainsKey(val)) freq[val] = weight;
          else freq[val] += weight; 
        }

        foreach (var item in items2) {
          var val = item[0]; 
          var weight = item[1];

          if (!freq.ContainsKey(val)) freq[val] = weight;
          else freq[val] += weight; 
        }

        var kvpList = new List<KeyValuePair<int, int>>(freq);

        kvpList.Sort((x, y) => x.Key.CompareTo(y.Key));

        var result = new List<IList<int>>();
        foreach (var kvp in kvpList) {
            result.Add(new List<int> { kvp.Key, kvp.Value });
        }

        return result;
    }
}