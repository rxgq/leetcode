namespace leetcode.easy;

public partial class MyHashSet {
    private List<int> Values { get; set; } = new();

    public MyHashSet() {}
    
    public void Add(int key) {
        if (Values.Contains(key)) return;
        Values.Add(key);
    }
    
    public void Remove(int key) {
        if (!Values.Contains(key)) return;
        Values.Remove(key);
    }
    
    public bool Contains(int key) {
        return Values.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */