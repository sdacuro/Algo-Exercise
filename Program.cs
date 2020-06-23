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
            list.RemoveFirst();
            list.RemoveLast();
            list.AddFirst(40);

            var size =  list.Size();
            var result = list.Contains(120);
        }
    }
}
