namespace leetcode.easy;

public partial class Solution {
    public int CalPoints(string[] ops) {
        var record = new List<int>();

        for (int i = 0; i < ops.Length; i++) {
            if (int.TryParse(ops[i], out int val)) record.Add(val);
            if (ops[i] == "+") record.Add(record[record.Count - 1] + record[record.Count - 2]);
            if (ops[i] == "D") record.Add(2 * record[record.Count - 1]);
            if (ops[i] == "C") record.RemoveAt(record.Count - 1);
        }

        return record.Sum();
    }
}