using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue que = new Queue();
            que.Enqueue(70);
            que.Enqueue(30);
            que.Enqueue(56);
            que.Dequeue();
            que.Display();
        }
    }
}


