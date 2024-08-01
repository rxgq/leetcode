namespace leetcode.easy;

public partial class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        (string name, int height)[] people = new (string, int)[names.Length];
        for (int i = 0; i < names.Length; i++)
            people[i] = (names[i], heights[i]);

        Array.Sort(people, (a, b) => b.height.CompareTo(a.height));

        string[] result = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
            result[i] = people[i].name;

        return result;
    }
}