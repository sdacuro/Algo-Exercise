using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Algo.LinkedList.LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            System.Console.WriteLine(string.Join(",", list.ToArray()));
            list.Reverse();
            System.Console.WriteLine(string.Join(",", list.ToArray()));


          
        }
    }
}
