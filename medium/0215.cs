namespace leetcode.medium;

public partial class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var heap = new PriorityQueue<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            heap.Enqueue(nums[i], nums[i]);
            if (heap.Count > k) heap.Dequeue();
        }

        return heap.Peek();
    }
}