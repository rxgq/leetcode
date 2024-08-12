namespace leetcode.easy;

public partial class Solution {
    public int[] ShortestToChar(string s, char c) {
        int[] arr = new int[s.Length];
        int n = s.Length;
        
        int lastPosition = -n;
        for (int i = 0; i < n; i++) {
            if (s[i] == c) lastPosition = i;
            
            arr[i] = i - lastPosition;
        }
        
        lastPosition = 2 * n;
        for (int i = n - 1; i >= 0; i--) {
            if (s[i] == c) lastPosition = i;

            arr[i] = Math.Min(arr[i], lastPosition - i);
        }
        
        return arr;
    }
}
