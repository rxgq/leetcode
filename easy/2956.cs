namespace leetcode.easy;

public partial class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        int answer1 = 0;
        int answer2 = 0;

        foreach (int num in nums1)
            if (set2.Contains(num))
                answer1++;

        foreach (int num in nums2)
            if (set1.Contains(num))
                answer2++;

        return new[] { answer1, answer2 };
    }
}
