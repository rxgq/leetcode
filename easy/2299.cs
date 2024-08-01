namespace leetcode.easy;

public partial class Solution {
    public bool StrongPasswordCheckerII(string p) {
        if (p.Length < 8) return false;

        bool hasLower = false;
        bool hasUpper = false;
        bool hasDigit = false;
        bool hasSpecial = false;
        
        char previous = ' ';
        foreach (char c in p) {
          if (c == previous) return false;
          previous = c;

          if (!hasDigit) hasDigit = char.IsDigit(c);;
          if (!hasSpecial) hasSpecial = !char.IsLetterOrDigit(c);
          if (!hasUpper) hasUpper = char.IsUpper(c);
          if (!hasLower) hasLower = char.IsLower(c);
        }

        return hasLower && hasUpper && hasDigit && hasSpecial;
    }
}