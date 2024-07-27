namespace leetcode.medium;

public partial class Solution {
    public int Compress(char[] chars) {
        string s = "";

        int compressedCount = 0;
        int readIdx = 0;

        while (readIdx < chars.Length) {
          char currChar = chars[readIdx];

          int charCount = 0;
          while (readIdx < chars.Length && chars[readIdx] == currChar) {
            readIdx++;
            charCount++;
          }

          chars[compressedCount++] = currChar;
          if (charCount > 1) {
            foreach (var digit in charCount.ToString())
              chars[compressedCount++] = digit;
          } 
        }

        return compressedCount;
    }
}