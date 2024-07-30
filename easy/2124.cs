namespace leetcode.easy;

public partial class Solution {
    public bool CheckString(string s) {
        int firstB = -1;
        for (int i = 0; i < s.Length; i++) {
          if (s[i] == 'b') 
            firstB = i;

          if (firstB != -1 && s[i] == 'a')
            return false;
        }

        return true;
    }
}