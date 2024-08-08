namespace leetcode.easy;

public partial class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] sArr = s.Split(' ');
        if (pattern.Length != sArr.Length) return false;

        var map = new Dictionary<char, string>();
        for (int i = 0; i < pattern.Length; i++) {
            char c = pattern[i];
            
            if (!map.ContainsKey(c)) {
                if (map.ContainsValue(sArr[i])) return false;
                map[c] = sArr[i];
            } else if (map[c] != sArr[i]) return false;
        }

        foreach (var kvp in map) Console.WriteLine($"{kvp.Key}: {kvp.Value}");

        return true;
    }
}