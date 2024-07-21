using System.Text;

namespace leetcode.easy;

public partial class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var set = new HashSet<string>();

        string[] morse = new string[] {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
        "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
        "..-", "...-", ".--", "-..-", "-.--", "--.."
    };

        foreach (string word in words)
        {
            var sb = new StringBuilder();

            foreach (char c in word)
            {
                int index = c - 'a';
                sb.Append(morse[index]);
            }

            set.Add(sb.ToString());
        }

        return set.Count;
    }
}
