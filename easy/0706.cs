namespace leetcode.easy;

public partial class MyHashMap {
    private int[] map { get; set; }

    public MyHashMap() {
      map = new int[10000001];    
    }
    
    public void Put(int key, int value) {
        map[key] = value + 1;
    }
    
    public int Get(int key) {
        return map[key] - 1;
    }
    
    public void Remove(int key) {
        map[key] = 0;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */