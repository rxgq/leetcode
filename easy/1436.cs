namespace leetcode.easy;

public partial class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var cities = new HashSet<string>();

        foreach (List<string> path in paths)
          cities.Add(path[0]);

        foreach (var path in paths) {
          foreach (var city in path) {
            if (!cities.Contains(city))
              return city;
          }
        }

        return ""
    }
}