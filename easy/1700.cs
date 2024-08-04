namespace leetcode.easy;

public partial class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int[] count = new int[2];
        foreach (var student in students) count[student]++;

        int i = 0;
        while (i < sandwiches.Length) {
          if (count[sandwiches[i]] == 0) 
            break;

          count[sandwiches[i]]--; 
          i++;
        }

        return students.Length - i;
    }
}