namespace leetcode.easy;

public partial class OrderedStream {
    private string[] stream;
    private int pointer;

    public OrderedStream(int n) {
        stream = new string[n + 1];
        pointer = 1;
    }
    
    public IList<string> Insert(int idKey, string value) {
        stream[idKey] = value;
        
        List<string> result = new List<string>();
        
        while (pointer < stream.Length && stream[pointer] != null) {
            result.Add(stream[pointer]);
            pointer++;
        }
        
        return result;
    }
}


/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */