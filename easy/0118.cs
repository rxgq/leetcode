using System.Collections.Generic;

namespace leetcode.easy
{
    public partial class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 0) return new List<IList<int>>();
            if (numRows == 1) return new List<IList<int>> { new List<int> { 1 } };

            var rows = new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };
            for (int i = 2; i < numRows; i++) {
                var newRow = new List<int> { 1 };

                var previousRow = rows[i - 1];
                for (int j = 1; j < i; j++)
                    newRow.Add(previousRow[j - 1] + previousRow[j]);

                newRow.Add(1);
                rows.Add(newRow);
            }

            return rows;
        }
    }
}
