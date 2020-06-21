using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=
            LinkedList<String> list = new LinkedList<string>();
            list.AddLast("10");
            list.AddLast("30");
            list.AddLast("30");
            list.AddFirst("5");


            System.Console.WriteLine(string.Join(",", list));
            */
            var list = new Algo.LinkedList.LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(40);

            var result = list.IndexOf(40);





        }
    }
}
