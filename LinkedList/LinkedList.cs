using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class LinkedList
    {
        // Search for unordered and ordered lists
        private Node head;
        public Node Head { get; set; }
        public void AddNode(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void SearchNode(int value)
        {
            if (head == null)
            {
                Console.WriteLine("// nothing here");
                return;
            }

            Node current = head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    Console.WriteLine(current.Value);
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("// Doesn't exist");
           
        }

        public void TraverseNode()
        {
            if (head == null)
            {
                Console.WriteLine("// nothing here");
                return;
            }

            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

           
        }

        public void DeleteNode(int value)
        {
            if (head == null)
            {
                Console.WriteLine("// nothing here");
                return;
            }

            if (head.Value == value)
            {
                head = head.Next;
                return;
            }

            // We check that the list is not null in its following nodes
            Node current = head;
            while (current.Next != null)
            {
                // We verify that the next node is the one with the value to be removed before operating on it
                if (current.Next.Value == value)
                {
                    Console.WriteLine("Deleted value: " + current.Next.Value);

                    // Instead of saying that the 'current' node's next is the node to be deleted, we make the pointer equal to
                    // that of the node to be deleted
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("// Doesn't exist");
        }
    }
}
