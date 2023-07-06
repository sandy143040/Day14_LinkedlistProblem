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
            customLinkedlist.Append(56);
            customLinkedlist.Append(30);
            customLinkedlist.Append(70);
            customLinkedlist.Display();

            Console.ReadLine();
        }
    }
}
