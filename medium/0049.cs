namespace leetcode.medium;

public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string key = new string(charArray);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(str);
        }

        return new List<IList<string>>(map.Values);
    }
}
