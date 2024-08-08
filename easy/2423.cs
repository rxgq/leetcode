namespace leetcode.easy;

public partial class Solution {
    public bool EqualFrequency(string word) {
        var freq = new Dictionary<char, int>();
        foreach (char c in word)
            freq[c] = freq.TryGetValue(c, out int val) ? ++val : 1;

        var freqOfFreq = new Dictionary<int, int>();
        foreach (int c in freq.Values)
            freqOfFreq[c] = freqOfFreq.TryGetValue(c, out int val) ? ++val : 1;

        foreach (var kvp in freqOfFreq) Console.Write(kvp.Key + " " + kvp.Value);

        if (freqOfFreq.Count == 1) {
            foreach (var kvp in freqOfFreq) 
                if (kvp.Value == 1) return true;

            if (freqOfFreq.ContainsKey(1)) return true;
        }

        if (freqOfFreq.Count == 2) {
            var keys = freqOfFreq.Keys.ToList();
            int f1 = keys[0], f2 = keys[1];
            
            if (f1 > f2) {
                int temp = f1;
                f1 = f2;
                f2 = temp;
            }

            if (f1 == 1 && freqOfFreq[f1] == 1)
                return true;
            
            if (f2 == f1 + 1 && freqOfFreq[f2] == 1)
                return true;
        }
        
        return false;
    }
}