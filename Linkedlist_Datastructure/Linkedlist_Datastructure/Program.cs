using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedlist customLinkedlist = new CustomLinkedlist();
            customLinkedlist.Add(70);
            customLinkedlist.Add(30);
            customLinkedlist.Add(56);
            customLinkedlist.Display();
            Console.ReadLine();
        }
    }
}
