public class DoublyLinkedLists {
    public DllNode Head;
    public void AddToBack (int val) {
        System.Console.WriteLine ("***************");
        System.Console.WriteLine ("Add to back");
        System.Console.WriteLine ("***************");
        DllNode newNode = new DllNode (val);
        if (Head == null) {
            Head = newNode;
            System.Console.WriteLine ("Head Added: " + newNode.Value + " Next: " + newNode.Next + " Prev: " + newNode.Prev);
        } else {
            DllNode runner = Head;
            while (runner.Next != null) {

                runner = runner.Next;
            }
            newNode.Prev = runner;
            runner.Next = newNode;
            System.Console.WriteLine ("Node Added: " + newNode.Value + " Next: " + newNode.Next + " Prev: " + newNode.Prev);
        }
    }
    public void Reverse () {
        System.Console.WriteLine ("***************");
        System.Console.WriteLine ("Revers");
        System.Console.WriteLine ("***************");
        if (Head == null) {
            System.Console.WriteLine ("***************");
            System.Console.WriteLine (" DLL is empty");
            System.Console.WriteLine ("***************");
        } else {
            DllNode temp;
            DllNode runner = Head;
            while (runner != null) {
                temp = runner.Prev;
                runner.Prev = runner.Next;
                runner.Next = temp;
                if (runner.Prev == null) {
                    Head = temp.Prev;
                }
                runner = runner.Prev;
            }
            System.Console.WriteLine ("Head is " + Head.Value);
        }
    }
    public void Remove (int val) {
        System.Console.WriteLine ("***************");
        System.Console.WriteLine ("Remove Value");
        System.Console.WriteLine ("***************");
        if (Head == null) {
            System.Console.WriteLine ("***************");
            System.Console.WriteLine (" DLL is empty");
            System.Console.WriteLine ("***************");
        }
        if (Head.Value == val) {
            if (Head.Next != null) {
                var temp = Head.Next;
                System.Console.WriteLine ("Org Head Val: " + Head.Value);
                Head = temp;
                Head.Prev = null;
                System.Console.WriteLine ("New Head Val: " + Head.Value);
            } else {
                Head = null;
                System.Console.WriteLine ("Remove last elment");
            }
        }
        DllNode runner = Head;
        while (runner != null) {
            if (val == runner.Value) {
                System.Console.WriteLine (runner.Value + " - prev " + runner.Prev + " - " + runner.Next);
                // var temp = runner.Prev.Prev;
                var nex = runner.Next;
                runner = runner.Prev;
                System.Console.WriteLine (runner.Value + " - prev " + runner.Prev + " - " + runner.Next);
                runner.Next = nex;
                System.Console.WriteLine (runner.Value + " - prev " + runner.Prev + " - " + runner.Next);
            }
            runner = runner.Next;
        }

    }
    public void Print () {
        if (Head == null) {
            System.Console.WriteLine ("***************");
            System.Console.WriteLine ("DLL is empty");
            System.Console.WriteLine ("***************");
        } else {
            DllNode runner = Head;
            int count = 0;
            System.Console.WriteLine ("***************");
            while (runner != null) {
                count++;
                System.Console.WriteLine ("Node: " + runner.Value + " Next: " + runner.Next + " Prev: " + runner.Prev);
                runner = runner.Next;
            }
            System.Console.WriteLine ("Counter is: " + count);
            System.Console.WriteLine ("***************");
        }
    }
}