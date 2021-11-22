using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(30);
            link.Add(70);
            link.Display();
            int position = link.Search(40);
            link.DeleteNodeAtParticularPosition(position);
        }
    }
}


