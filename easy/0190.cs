namespace leetcode.easy;

public partial class Solution {
    public uint reverseBits(uint n) {
        uint reversed = 0;
        for (int i = 0; i < 32; i++) {
            uint bit = (n >> i) & 1;
            reversed = (reversed << 1) | bit;
        }

        return reversed;
    }
}