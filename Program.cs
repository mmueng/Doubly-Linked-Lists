using System;
using System.Collections.Generic;
namespace Doubly_Linked_Lists {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Doubly Linked List");
            DoublyLinkedLists Dll = new DoublyLinkedLists ();
            Dll.AddToBack (1);
            Dll.AddToBack (2);
            Dll.AddToBack (3);
            Dll.AddToBack (4);
            Dll.Print ();
            // Dll.Remove (4);
            // Dll.Remove (1);
            Dll.Reverse ();
            Dll.Print ();
        }
    }
}