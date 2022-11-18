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
        class DoubleLinkedList
        {
            Node START;
            //construktor
            public void addNode()
            {
                int nim;
                string nm;
                Console.WriteLine("\nEnter the roll number of the student: ");
                nim = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the name of the student: ");
                nm = Console.ReadLine();
                Node newNode = new Node();
                newNode.noMhs = nim;
                newNode.name = nm;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
