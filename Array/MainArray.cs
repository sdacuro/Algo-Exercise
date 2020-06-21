using System;

namespace Algo
{
    class ProgramArray
    {
        static void Main2(string[] args)
        {
            var numbers = new Array2(3);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);
            //numbers.RemoveAt(4);
            numbers.IntertAt(100,2);
            numbers.Reverse();
             numbers.Print();


        }
    }
}
