namespace leetcode.easy;

public partial class Solution {
    public int MaxNumberOfBalloons(string text) {
        var freq = new Dictionary<char, int>();

        foreach (char c in text) {
            if (!freq.ContainsKey(c)) freq[c] = 1;
            else freq[c]++;
        }

        if (!freq.ContainsKey('b') || !freq.ContainsKey('a') || !freq.ContainsKey('l') || !freq.ContainsKey('o') || !freq.ContainsKey('n')) 
            return 0;

        int minSingle = Math.Min(freq['b'], Math.Min(freq['a'], freq['n']));
        int minDouble = Math.Min(freq['l'], freq['o']) / 2;

        return Math.Min(minSingle, minDouble);
    }
}