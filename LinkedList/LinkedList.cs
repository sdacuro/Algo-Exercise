using System;

namespace Algo.LinkedList
{
    public class LinkedList
    {
        private class Node 
        {
            public int Value;
            public Node Next;

            public Node(int item)
            {
                this.Value = item;
            }
        }

        private Node _first;
        private Node _last;

        public void AddFirst(int value) 
        {
            var node = new Node(value);
            if (IsEmpty())
                _first = _last = node;
            else
            {
                node.Next = _first;
                _first = node ;
            }
        }
        public void AddLast(int value)
        {
            var node = new Node(value);
            if (IsEmpty())
                _first = _last = node;
            else
            {
                _last.Next = node;
                _last = node;
            }
        }

        private bool IsEmpty()
        {
            return (_first == null);
        }
        // deleteFirst
        // DeleteLast
        // Contains
        public int IndexOf(int item)
        {
            int counter = 0;
            var currentNode = _first;
            while (currentNode != null)
            {
                if (currentNode.Value == item)
                    return counter;
                currentNode = currentNode.Next;
                counter++;
            }
            return -1;
        }
    }


}