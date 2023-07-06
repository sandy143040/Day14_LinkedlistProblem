using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Datastructure
{
    public class CustomLinkedlist
    {
        public void CreateList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            foreach(int val in list)
            {
                Console.Write(val+"->");
            }
        }
    }
}
