namespace leetcode.easy;

public partial class Solution {
    public int GetLucky(string s, int k) {
        string seq = "";
        foreach (char c in s) 
            seq += c - 'a' + 1;

        for (int i = 0; i < k; i++) {

            int sum = 0;
            foreach (char c in seq)
                sum += int.Parse(c.ToString());

            seq = sum.ToString();
        }

        return int.Parse(seq);
    }
}