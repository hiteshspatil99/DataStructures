﻿using System;

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
            int search = link.Search(30);
            Console.WriteLine(search);
        }
    }
}


