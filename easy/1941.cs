namespace leetcode.easy;

public partial class Solution {
    public bool AreOccurrencesEqual(string s) {
        var freq = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!freq.ContainsKey(c)) freq[c] = 1;
            else freq[c]++; 
        }

        int balance = freq.First().Value;
        foreach (var item in freq) 
            if (item.Value != balance) return false;

        return true; 
    }
}