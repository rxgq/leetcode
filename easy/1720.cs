namespace leetcode.easy;

public partial class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] arr = new int[encoded.Length + 1];

        arr[0] = first;
        for (int i = 1; i <= encoded.Length; i++) {
          arr[i] = encoded[i - 1] ^ arr[i - 1];
        }

        return arr;
    }
}