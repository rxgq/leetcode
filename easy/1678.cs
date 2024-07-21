namespace leetcode.easy;

public partial class Solution
{
    public string Interpret(string command)
    {
        char[] result = new char[command.Length];
        int index = 0;

        for (int i = 0; i < command.Length;)
        {
            if (command[i] == 'G')
            {
                result[index++] = 'G';
                i++;
            }
            else if (command[i] == '(' && command[i + 1] == ')')
            {
                result[index++] = 'o';
                i += 2;
            }
            else
            {
                result[index++] = 'a';
                result[index++] = 'l';
                i += 4;
            }
        }

        return new string(result, 0, index);
    }
}
