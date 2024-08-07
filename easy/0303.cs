namespace leetcode.easy;

public partial class NumArray {
    private readonly int[] arr;
    
    public NumArray(int[] nums) {
        arr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
            arr[i] = i == 0 ? nums[i] : arr[i - 1] + nums[i];
    }
    
    public int SumRange(int l, int r) {
        if (l == 0)
            return arr[r];

        return arr[r] - arr[l -1 ];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */