namespace leetcode;

public partial class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        if (s == null || s.Length < 2)
            return false;

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);

            else if (c == ')')
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;

            else if (c == '}')
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            
            else if (c == ']')
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
        }

        return stack.Count == 0;
    }
}

