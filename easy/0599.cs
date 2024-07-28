namespace leetcode.easy;

public partial class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
      List<string> common = new(); 
      int smallestSum = 99999;

        for (int i = 0; i < list1.Length; i++) {
          for (int j = 0; j < list2.Length; j++) {
            if (list1[i] == list2[j] && i + j <= smallestSum) {
              if (i + j < smallestSum) common.Clear();

              smallestSum = i + j;
              common.Add(list1[i]);
            }
          }
        }

        return common.ToArray();
    }
}