namespace leetcode.easy;

public partial class Solution {
    public int MinLength(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
          if (stack.Count > 0) {
            char top = stack.Peek();
            if ((top == 'A' && c == 'B') || (top == 'C' && c == 'D')) {
              stack.Pop();
            } else {
              stack.Push(c);
            }
          } else {
            stack.Push(c);
          }
        }

        return stack.Count;
    }
}