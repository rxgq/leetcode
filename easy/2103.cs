namespace leetcodee.easy;

public partial class Solution {
    public int CountPoints(string rings) {
        var rods = new Dictionary<int, HashSet<char>>();

        for (int i = 0; i < rings.Length - 1; i += 2) {
          var color = rings[i];
          var rod = rings[i + 1];

          if (!rods.ContainsKey(rod)) rods[rod] = new HashSet<char>();
          rods[rod].Add(color);
        }

        int count = 0;
        foreach (var kvp in rods)
          if (kvp.Value.Count == 3) count++;

        return count;
    }
}