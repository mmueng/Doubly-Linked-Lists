public class DllNode {
    public int Value;
    public DllNode Next;
    public DllNode Prev;
    public DllNode (int val) {
        this.Value = val;
        this.Next = null;
        this.Prev = null;
    }
}