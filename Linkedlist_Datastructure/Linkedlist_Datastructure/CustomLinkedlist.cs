using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Datastructure
{
    public class CustomLinkedlist
    {
        public Node head;
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkelist", newNode.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} node is added into linkelist", newNode.data);
            }
        }
        public void InsertNode(int idx, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            int index = 0;
            while (index < idx - 1)
            {
                temp = temp.next;
                index++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            Console.WriteLine("{0} node is inserted after 30 to LinkedList", newNode.data);
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine("null");
            }
        }
    }
}
