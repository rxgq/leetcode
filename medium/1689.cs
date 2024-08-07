namespace leetcode.medium;

public partial class Solution {
    public int MinPartitions(string n) {
        return n.Max() - '0';
    }
}