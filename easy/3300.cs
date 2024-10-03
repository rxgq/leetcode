public partial class Solution {
    public int MinElement(int[] nums) {
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) {
            var digits = nums[i].ToString().ToCharArray();
            
            int total = 0;
            foreach(char c in digits)
                total += int.Parse(c.ToString());

            min = Math.Min(min, total);
        }

        return min;
    }
}