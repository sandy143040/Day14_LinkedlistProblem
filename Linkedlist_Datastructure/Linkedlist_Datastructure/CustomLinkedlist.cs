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
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public void Display()
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            else
            {
                while(temp != null)
                {
                    Console.Write(temp.data+"->");
                    temp = temp.next;
                }
                Console.WriteLine("null");
            }
        }
    }
}
