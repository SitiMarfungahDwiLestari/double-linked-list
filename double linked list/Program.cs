using System;

namespace double_linked_list
{
    class Program
    {
        class Node
        {
            //Node class represent the node of doubly linked list
            //It consist of the information part and links to
            //Its succending and preccending
            //In terms of next and previous
            public int noMhs;
            public string name;
            //point to the succending node
            public Node next;
            //point to the preceending node
            public Node prev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
